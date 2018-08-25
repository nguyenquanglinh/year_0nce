using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BieuThucTrungToSoLonConsole
{
    public class ChuyenTrungToSangHauTo
    {
        List<object> items = new List<object>();

        private static List<object> SplitItem(string str)
        {
            string[] sep = { "+", "-", "*", ")", "(", "^", "/" };
            foreach (var item in sep)
            {
                str = str.Replace(item, " " + item + " ");
            }
            var arr = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<object>();
            int demToanTu = 0;
            int demSoLon = 0;
            foreach (var item in arr)
            {
                if ('0' <= item[0] && item[0] <= '9')
                {
                    demSoLon++;
                    result.Add(new SoLon(item));
                }
                else
                {
                    result.Add(item);
                    demToanTu++;
                }
                //if (demSoLon - 1 < demToanTu)
                //    return null;
            }
            return result;
        }

        /// <summary>
        /// hàm tạo truyền đầu vào
        /// </summary>
        /// <param name="s">chuỗi trung tố</param>
        public ChuyenTrungToSangHauTo(string s)
        {
            if (!IsCorrectString(s))
                throw new ArgumentException("Chuỗi không hợp lệ");
            items = SplitItem(s);
            if (items == null)
                throw new Exception("các toán tử đang nhiều hơn các số hạng ");
        }

        /// <summary>
        /// kiểm tra chuỗi đúng
        /// </summary>
        /// <param name="mangChar"></param>
        /// <returns></returns>
        static bool IsCorrectString(string mangChar)
        {
            int mo = 0, dong = 0;
            for (int i = 0; i < mangChar.Length; i++)
            {
                if (mangChar[i] == '(')
                    mo++;
                if (mangChar[i] == ')')
                    dong++;
                if (mo < dong)
                    return false;
            }
            return mo - dong == 0;
        }

        //độ ưu tiên toán tử
        int Priority(string Char)
        {
            if (Char == "%" || Char == "^")
                return 3;
            if (Char == "*" || Char == "/")
                return 2;
            if (Char == "+" || Char == "-")
                return 1;
            return 0;
        }

        //in ra hau to
        public List<object> PrintScreenRessults()
        {
            List<object> result = new List<object>();
            var stack = new Stack<object>();

            foreach (var item in items)
            {
                if (item == "(")
                {
                    stack.Push(item);

                }
                else if (item == ")")
                {
                    var kqTrongStack = stack.Pop();
                    while (kqTrongStack != "(")
                    {
                        result.Add(kqTrongStack);
                        kqTrongStack = stack.Pop();
                    }
                }
                else if (item is string) // là phép toán 
                { 
                    while (stack.Count > 0 && Priority((string)item) <= Priority((string)stack.Peek()))
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Push(item);
                }
                else // Là số lớn
                    result.Add(item);
            }

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }
            return result;
        }

        //////phep toan ket qua
        void StackPusk(Stack<object> obj, string x)
        {
            var x1 = (SoLon)obj.Pop();
            var x2 = (SoLon)obj.Pop();
            if (x == "+")
                obj.Push(x1 + x2);
            else if (x == "-")
                obj.Push(x2 - x1);
            else if (x == "*")
                obj.Push(x1 * x2);
        }

        public string Expressions()
        {
            var s = PrintScreenRessults();
            var stack = new Stack<object>();
            foreach (var item in s)
            {
                if (item is string)
                {
                    var x = item as string;
                    StackPusk(stack, x); 
                }
                else
                    stack.Push(item);
            }
            return stack.Pop().ToString();
        }

        //la toaan hang string
        bool IsOperatorString(string s)
        {
            return s == "+" || s == "-" || s == "*" || s == "^" ;
        }

        //in ket quả
        public string InManHinh()
        {
            var s = "";
            foreach (var item in items)
            {
                s += item;
            }
            s += "=";
            foreach (var item in PrintScreenRessults())
            {
                s += item + " ";
            }
            s += " = " + Expressions();
            return s;

        }
    }
}
