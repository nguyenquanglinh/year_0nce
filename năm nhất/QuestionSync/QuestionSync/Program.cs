using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSync
{
    class Program
    {


        static void Main(string[] args)
        {
            var fileIter = new MongodbStore();
            var fileOf = new FileSystemQuestionSore("data");
            var up = new synchronized(fileOf, fileIter);
            up.UpdateFileSystem();
            up.UpdateFileMdd();
            up.Update();
            return;
        }
    }
}
