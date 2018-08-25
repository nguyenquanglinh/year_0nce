using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudukuNew
{
   public class FileText
    {
        string path = "D:\\LapTrinh\\GameSudoku\\Data";
        //Lấy tên các file
        public FileText(ComboBox cbb)
        {
            cbb.Items.Clear();
            var tenThuMuc = Directory.GetFiles(path);
            foreach (string fileName in tenThuMuc)
            {
                string tenFile = "";
                tenFile = Path.GetFileName(fileName).Trim();
                string ten = tenFile.Remove(tenFile.Length - 4, 4);
                cbb.Items.Add(ten);
            }

        }
        //lấy dữ liệu trong File trả về 1 mảng arr
        public int[,] LayDuLieuText(string tenFile)
        {
            var pathFile = path + "\\" + tenFile + ".txt";
            int[,] arr = new int[9, 9];
            var fileString = File.ReadAllText(pathFile);
            var s = fileString.ToString().ToCharArray();
            if (s.Length < 81)
            {
                MessageBox.Show("câu hỏi đã nhập sai");
                return null;
            }
            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Char.IsNumber(s[k]) == false)
                    {
                        MessageBox.Show("câu hỏi đã bị nhập sai");
                        return null;
                    }
                    arr[i, j] = int.Parse(s[k].ToString());
                    k++;
                }
            }
            return arr;
        }

    }
}
