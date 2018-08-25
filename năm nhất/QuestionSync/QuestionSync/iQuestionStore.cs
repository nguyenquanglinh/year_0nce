using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace QuestionSync
{
    public class Question
    {

        public Question()
        {
            var ss = ObjectId.GenerateNewId();
            id = ss;
        }
        public string Name { get; set; }
        public string Data { get; set; }
        public ObjectId id { get; set; }
    }

    interface IQuestionStore
    {
        List<string> GetAllQuestionName();
        Question GetQuestion(string name);
        void AddQuestion(Question question);
    }


    public class FileSystemQuestionSore : IQuestionStore
    {
        string path = "C:\\Users\\pc\\Desktop\\";
        public FileSystemQuestionSore(string Ipath)
        {
            path += Ipath;
        }

        public List<string> GetAllQuestionName()
        {
            //lấy các tên file trong dường dẫn path

            var tenThuMuc = Directory.GetFiles(path);
            var tapTen = new List<string>();
            foreach (string fileName in tenThuMuc)
            {
                string tenFile = "";
                tenFile = Path.GetFileName(fileName).Trim();
                tapTen.Add(tenFile);
            }
            return tapTen;
        }

        public Question GetQuestion(string name)
        {
            string ttt = path + "\\" + name;
            var cauHoi = File.ReadAllText(ttt);
            var qs = new Question();
            qs.Name = name;
            qs.Data = cauHoi;

            return qs;
        }

        public void AddQuestion(Question question)
        {
            var path1 = path+"\\" + question.Name;
            string appendText = question.Data + Environment.NewLine;
            File.AppendAllText(path1, appendText);

        }
    }

    public class MongodbStore : IQuestionStore
    {
        private MongoClient client;
        private IMongoCollection<Question> colection;
        private IMongoDatabase database;
        public MongodbStore()
        {
            client = new MongoClient(new MongoUrl("mongodb://nbhoa:nbhoa@ds245337.mlab.com:45337/chiecnongkydieu"));
            database = client.GetDatabase("chiecnongkydieu");
            colection = database.GetCollection<Question>("question");
        }
        public List<string> GetAllQuestionName()
        {
            var fieldsBuilder = Builders<Question>.Projection;
            var fields = fieldsBuilder.Exclude(d => d.Data).Exclude(d => d.id);

            return colection.Find(_ => true).Project<Question>(fields).ToList().Select(x => x.Name).ToList();

        }

        public void AddQuestion(Question question)
        {
            colection.InsertOne(question);
        }

        public Question GetQuestion(string name)
        {
            var ten = GetAllQuestionName();
            var fieldbuilder = Builders<Question>.Filter.Eq(d => d.Name, name);
            var fields = Builders<Question>.Projection.Include(d => d.Data).Exclude(d => d.id).Include(d => d.Name);
            var listQuestions = colection.Find(fieldbuilder).Project<Question>(fields).ToList().Select(x => x).AsQueryable().ToList();
            return listQuestions[0];
        }
    }

    public class synchronized
    {
        FileSystemQuestionSore system { get; set; }
        MongodbStore mdb { get; set; }

        public synchronized(FileSystemQuestionSore systemStore, MongodbStore mDBStore)
        {
            system = systemStore;
            mdb = mDBStore;
        }

        public void UpdateFileMdd()
        {
            var fileSystem = system.GetAllQuestionName();
            var fileMdb = mdb.GetAllQuestionName();
            //lấy 1 tên file mdb so sánh với từng tên của file system
            foreach (var name in fileSystem)
            {
                //chưa có file trên mdb 
                if (!FileExist(fileMdb, name))
                {
                    //lấy question trên system push lên mdb
                    var questions = system.GetQuestion(name);
                    mdb.AddQuestion(questions);
                }
            }
        }

        bool FileExist(List<string> listName, string name)
        {
            foreach (var item in listName)
            {
                if (item == name)
                    return true;
            }
            return false;
        }

        public void UpdateFileSystem()
        {
            var fileSystem = system.GetAllQuestionName();
            var fileMdb = mdb.GetAllQuestionName();
            //lấy 1 tên file system so sánh với từng tên của file mdb
            foreach (var name in fileMdb)
            {
                //chưa có file trên sytem 
                if (!FileExist(fileSystem, name))
                {
                    //lấy question mdb xuống system
                    var questions = mdb.GetQuestion(name);
                    system.AddQuestion(questions);
                }
            }
        }

        public void Update()
        {
            UpdateFileMdd();
            UpdateFileSystem();
        }

    }

}
