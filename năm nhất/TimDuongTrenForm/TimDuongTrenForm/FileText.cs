using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimDuongTrenForm
{
    public class FileText
    {
        string pathDinh = "D:\\BaiTap1\\TimDuongTrenForm\\Data\\";
        string pathArr = "D:\\BaiTap1\\TimDuongTrenForm\\Data\\Arr\\";
        DoThi dT;
        public FileText(DoThi dt)
        {
            dT = dt;

        }
        public void LuuFile(string fileName)
        {
            LuuFileDinh(fileName);
            LuuFileCanh(fileName);
        }

        void LuuFileDinh(string fileName)
        {
            string pathDinh1 = pathDinh+ fileName + ".txt";
            if (dT.tapDinh.Count > 0)
            {
                foreach (var item in dT.tapDinh)
                {
                    var x = item.Center.X;
                    var y = item.Center.Y;
                    var s = x + ";" + y;
                    string appendText = s + Environment.NewLine;
                    File.AppendAllText(pathDinh1, appendText);
                }
                MessageBox.Show("Đã lưu đồ thị trên form");
            }
            else
                MessageBox.Show("trên form không có đồ thị");
        }

        void LuuFileCanh(string fileName)
        {
            string pathArr1 = pathArr + fileName + ".txt";
            if (dT.tapCanh.Count == 0)
            {
                if (MessageBox.Show("bạn có muốn lưu file rỗng 0", "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string appendText1 = Environment.NewLine;
                    File.AppendAllText(pathArr1, appendText1);

                }
            }
            string appendText = dT.tapDinh.Count.ToString() + Environment.NewLine;
            File.AppendAllText(pathArr1, appendText);

            foreach (var item in dT.tapCanh)
            {
                var appendTextcanh = item.DiemDau.NameHt + " " + item.DiemCuoi.NameHt + Environment.NewLine;
                File.AppendAllText(pathArr1, appendTextcanh);
            }
        }

        public void DocFile(string FileName)
        {
            DocFileDinh(FileName);
            DocFileCanh(FileName);
          
        }

        private void DocFileDinh(string FileName)
        {
            string pathFile = pathDinh + FileName + ".txt";
            if (!File.Exists(pathFile))
            {
                MessageBox.Show("file không tồn tại");
                return;
            }
            var xx = File.ReadAllLines(pathFile);

            foreach (var item in xx)
            {
                var s = item.Split(';');
                dT.ThemDinh(int.Parse(s[0]), int.Parse(s[1]));
            }
        }

        private void DocFileCanh(string FileName)
        {
            string pathFile =pathArr + FileName + ".txt";
            if (!File.Exists(pathFile))
            {
                MessageBox.Show("file rỗng hoặc chưa được tạo");
                return;
            }
            var xx = File.ReadAllLines(pathFile);
            if (string.IsNullOrEmpty(xx[0]))
            {
                MessageBox.Show("file đã lưu sai");
                return;
            }
            for (int j = 1; j < xx.Length; j++)
            {
                var s = xx[j].Split(' ');

                var dDau = dT.LayHinhTron(int.Parse(s[0]));
                var dcuoi = dT.LayHinhTron(int.Parse(s[1]));
                var canh = new Canh(dDau, dcuoi);
                dT.ThemCanh(canh);
            }
        }



    }
}
