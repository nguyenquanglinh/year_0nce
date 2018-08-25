using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhSoLonBieuThucTrungTo
{
    class BieuThucTrungTo
    {
        string chuoi;
        char[] arr;
        public BieuThucTrungTo(string s)
        {
            QuyDoiChuoi = s;
        }
        string Input
        {
            get
            {
                return chuoi;
            }
            set
            {
                chuoi = value;
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("chưa biết lỗi này là gì");
            }
        }
        char[] ChuyenDoi
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }
        //chưa kiểm tra các phép tính của chuỗi
        bool LaChuoiDung(char[] mangchar)
        {
            int mo = 0, dong = 0;
            foreach (var item in mangchar)
            {
                if (item == '(')
                    mo++;
                else if (item == ')')
                    dong++;
                if (mo < dong)
                    return false;
            }
            return true;
        }
        //kiểm tra toán tử
        bool LaToanTu(char Char)
        {
            return (Char == '+' || Char == '-' || Char == '*' || Char == '/' || Char == '^' || Char == '!');
        }
        //độ ưu tiên toán tử
        int Priority(char Char)
        {
            if (Char == '%' || Char == '^' || Char == '!')
                return 3;
            if (Char == '*' || Char == '/')
                return 2;
            if (Char == '+' || Char == '-')
                return 1;
            return 0;
        }
        //tra man hinh ket quả
        public string BieuThucHauTo()
        {
            if (!LaChuoiDung(arr))
                throw new Exception("nhap sai mang");
            var stack = new Stack<object>();
            var ressults = "";
            foreach (var item in arr)
            {
                if (item == ' ')
                    continue;
                else if (Char.IsNumber(item))
                {
                    ressults += item;
                }
                else if (item == '(')
                {
                    stack.Push(item);

                }
                else if (item == ')')
                {
                    var kqTrongStack = stack.Pop();
                    while ((char)kqTrongStack != '(')
                    {
                        ressults += kqTrongStack;
                        kqTrongStack = stack.Pop();
                    }
                }
                else if (LaToanTu(item))
                {

                    while (stack.Count > 0 && Priority(item) <= Priority((char)stack.Peek()))
                    {
                        ressults += stack.Pop();
                    }
                    stack.Push(item);
                }
            }
            while (stack.Count > 0)
            {
                ressults += stack.Pop();
            }
            var s = ressults.ToCharArray();
            ressults = ChuyenVeChuoiDung(s);
            return ressults;
        }
        //viêt chuôi đúng
        string ChuyenVeChuoiDung(char[] ressults)
        {
            string[] toanTu = { "+", "-", "*", "(", ")", "^", "/" };
            var cacSoLon = chuoi.Split(toanTu, StringSplitOptions.RemoveEmptyEntries);
            var ressults1 = "";
            var s = "";
            int j = 0;
            foreach (var item in ressults)
            {
                s += item;
                if (LaToanTu(item))
                {
                    ressults1 += " " + item;
                    s = "";
                }
                else if (s == cacSoLon[j])
                {
                    ressults1 += " " + s + " ";
                    s = "";
                    j++;
                }
            }
            return ressults1;
        }
        //tính kết quả bình thường
        public string KetQuaSoInt()
        {
            var s = BieuThucHauTo();
            var stack = new Stack<object>();
            foreach (var item in s.Split(' '))
            {
                if (item == "")
                    continue;
                if (LaToanTuString(item))
                    PustackInt(stack, item);

            }
            return s;
        }
        void PustackInt(Stack<object> obj, string x)
        {
            var x1 = (int)obj.Pop();
            var x2 = (int)obj.Pop();
            if (x == "+")
                obj.Push(x1 + x2);
            else if (x == "-")
                obj.Push(x2 - x1);
            else if (x == "*")
                obj.Push(x1 * x2);
            else if (x == "/")
                obj.Push(x2 * 1.0 / x1);
            else if (x == "^")
                obj.Push(Math.Pow(x2, x1));
            else if (x == "!")
                obj.Push(GiaiThua((int)obj.Pop()));
        }


        int GiaiThua(int x)
        {

            for (int i = 1; i < x; i++)
            {
                x = x * (i);
            }
            return x;
        }

        #region
        //////////void PushStack(Stack<object> obj, string x)
        //////////{
        //////////    var x1 = (SoLon)obj.Pop();
        //////////    var x2 = (SoLon)obj.Pop();
        //////////    if (x == "+")
        //////////        obj.Push(x1 + x2);
        //////////    else if (x == "-")
        //////////        obj.Push(x2 - x1);
        //////////    else if (x == "*")
        //////////        obj.Push(x1 * x2);
        //////////    else if (x == "^")
        //////////        obj.Push(x2 ^ x1);
        //////////}
        ////////////tính kết quả bằng số lớn
        //////////public string Expressions()
        //////////{
        //////////    var s = BieuThucHauTo();
        //////////    var stack = new Stack<object>();
        //////////    foreach (var item in s.Split(' '))
        //////////    {
        //////////        if (item == "")
        //////////            continue;
        //////////        if (LaToanTuString(item))
        //////////        {
        //////////            PushStack(stack,item);
        //////////        }
        //////////        else if (item != "/")
        //////////            stack.Push(new SoLon(item));
        //////////    }
        //////////    return stack.Pop().ToString();
        //////////}
        #endregion
        bool LaToanTuString(string Char)
        {
            return (Char == "+" || Char == "-" || Char == "*" || Char == "/" || Char == "^" || Char == "!");
        }

        public string QuyDoiChuoi { get; set; }
    }
}
