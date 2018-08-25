using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeDoThiLienThong
{
    class FileText
    {
        string text { get; set; }

        public FileText(string toaDo)
        {
            text = toaDo;
        }
        #region GhiFile
        public void LuuToaDoCanh(string diaChi)
        {
            string path = "D:\\OutputCanhLocation.txt";
            //chưa xử lý
            var x = DocFileCanh(path);
            var s = "";
            string appendText = s + Environment.NewLine;
            File.AppendAllText(path, appendText);
        }
        public string[] DocFileCanh(string diachi)
        {
            string path = "D:\\OutputCanhLocation.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("file không tồn tại");
                return null;
            }
            else
                return File.ReadAllLines(path);
        }
        private string KiemTraDuLieuDaCo(string str)
        {
            var mChar = str.ToCharArray();
            var mText = text.ToCharArray();
            var s = "";
            //xuất hiện trường hợp file trung nhau thì không xét phần trùng
            if (mChar.Length >= mText.Length)
            {
                for (int i = 0; i < mText.Length; i++)
                {
                    if (mChar[i] == mText[i])
                        continue;

                }
            }
            return null;
        }


        #endregion
    }
}
