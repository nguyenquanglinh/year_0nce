using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.IO;

namespace InterFace
{
    class InterFace
    {
        string LoadAll()
        {
            string path = @"D:\Data.txt";
            return path;
        }

        void SaveAs(object v)
        {
            if (v is Nguoi)
            {
                var nguoi = v as Nguoi;
                string path = @"D:\Data.txt";
                string appendText = nguoi.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
            else
                return;
        }
    }
}
