using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DoThiTrenForm
{
    public interface CacFile
    {
        void LuuFile(string fileName, IDoThi doThi);
        IDoThi DocFile(string fileName);
    }

    public class FileText : CacFile
    {
        string dataPath = "D:\\BaiTap1\\TimDuongTrenForm\\Data\\";

        public FileText()
        {
        }

        public void LuuFile(string fileName, IDoThi doThi)
        {
            LuuFileDinh(fileName, doThi);
            LuuFileCanh(fileName, doThi);
        }

        private void LuuFileCanh(string fileName, IDoThi doThi)
        {
            string pathFileDinh = Path.Combine(dataPath, fileName + ".arr");
            foreach (var canh in doThi.TapCanh)
            {
                var appendTextCanh = canh + Environment.NewLine;
                File.AppendAllText(pathFileDinh, appendTextCanh);
            }

        }

        private void LuuFileDinh(string fileName, IDoThi doThi)
        {
            string pathFileDinh = Path.Combine(dataPath, fileName + ".pos");
            foreach (var dinh in doThi.TapDinh)
            {
                var appendTextDinh = dinh + Environment.NewLine;
                File.AppendAllText(pathFileDinh, appendTextDinh);
            }
        }

        private Tuple<string, string> GetDataFiles(string fileName)
        {
            string pathFile = Path.Combine(dataPath, fileName);
            return new Tuple<string, string>(pathFile + ".pos", pathFile + ".arr");
        }

        public IDoThi DocFile(string fileName)
        {
            IDoThi doThi = new DoThi();
            var toaDoDinh = DocFileText(GetDataFiles(fileName).Item1);
            var cacTapCanh = DocFileText(GetDataFiles(fileName).Item2);


            for (int i = 0; i < toaDoDinh.Count; i++)
            {
                var dDiem = new Diem() { Location = new Point(toaDoDinh[i][0], toaDoDinh[i][1]), PointName = i.ToString() };
                doThi.ThemDinh(dDiem);
            }

            for (int i = 0; i < cacTapCanh.Count; i++)
            {
                doThi.ThemCanh(new Canh(doThi[cacTapCanh[i][0].ToString()], doThi[cacTapCanh[i][1].ToString()]));
            }
            return doThi;
        }

        private List<int[]> DocFileText(string pathFileName)
        {
            var allLines = File.ReadAllLines(pathFileName);
            var tapGiaTri = new List<int[]>();
            foreach (var dong in allLines)
            {
                var arr = dong.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length != 2)
                    throw new DataInvalidException(pathFileName);

                tapGiaTri.Add(new int[] { int.Parse(arr[0]), int.Parse(arr[1]) });
            }
            return tapGiaTri;
        }
    }

    class DataInvalidException : Exception
    {
        public DataInvalidException(string pathFileName)
            : base("File loi:" + pathFileName)
        {
        }

    }
}


