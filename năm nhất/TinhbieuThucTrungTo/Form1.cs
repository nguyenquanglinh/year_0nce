using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhbieuThucTrungTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = txtTrungTo.Text;
            txttienTo.Text = PrintScreenRessults(s);
        }
        //kiểm tra chuỗi đúng
        bool IsCorrectString(char[] mangChar)
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
        //toán tử
        bool IsOperator(char Char)
        {
            if (Char == '+' || Char == '-' || Char == '*' || Char == '/' || Char == '%' || Char == '^' || Char == '!')
                return true;
            return false;
        }
        //số đếm
        bool IsNumber(Char Char)
        {
            if (Char == '9' || Char == '8' || Char == '7' || Char == '6' || Char == '5' || Char == '4' || Char == '3' || Char == '2' || Char == '1' || Char == '0')
                return true;
            return false;
        }
        //độ ưu tiên toán tử
        int Priority(char Char)
        {
            if (Char == '%' || Char == '^')
                return 3;
            if (Char == '*' || Char == '/')
                return 2;
            if (Char == '+' || Char == '-')
                return 1;
            return 0;
        }
        //in ra hậu tố
        public string PrintScreenRessults(string s)
        {
            var mangChar = new char[s.Length];
            mangChar = s.ToCharArray();
            if (!IsCorrectString(mangChar))
            {
                MessageBox.Show("bạn đã nhập sai biểu thứa");
                return " ";
            }
            var stack = new Stack<object>();
            var ressults = "";
            foreach (var item in mangChar)
            {
                if (item == ' ')
                    continue;
                else if (IsNumber(item))
                    ressults += item + " ";
                else if (item == '(')
                    stack.Push(item);
                else if (item == ')')
                {
                    var kqTrongStack = stack.Pop();
                    while ((char)kqTrongStack != '(')
                    {
                        ressults += kqTrongStack;
                        kqTrongStack = stack.Pop();
                    }
                }
                else if (IsOperator(item))
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
                ressults += stack.Pop() + " ";
            }
            return ressults;
        }
        //Tinh bieu thức
        public string Expressions(string s)
        {
            var mangChar = new char[s.Length];
            mangChar = s.ToCharArray();
            var stack = new Stack<object>();
           
            foreach (var item in mangChar)
            {
                if (item == ' ')
                    continue;
                else if (IsNumber(item))
                    stack.Push(item);
                else if (IsOperator(item))
                {
                    if (item == '+')
                    {
                        int x1 = int.Parse(stack.Pop().ToString());
                        int x2 = int.Parse(stack.Pop().ToString());
                        int x3 = x1 + x2;
                        stack.Push(x3);
                    }
                    else if (item == '-')
                    {
                        int x1 = int.Parse(stack.Pop().ToString());
                        int x2 = int.Parse(stack.Pop().ToString());
                        int x3 = x2 - x1;
                        stack.Push(x3);
                    }
                    else if (item == '*')
                    {
                        int x1 = int.Parse(stack.Pop().ToString());
                        int x2 = int.Parse(stack.Pop().ToString());
                        int x3 = x1 * x2;
                        stack.Push(x3);
                    }
                    else if (item == '/')
                    {
                        int x1 = int.Parse(stack.Pop().ToString());
                        int x2 = int.Parse(stack.Pop().ToString());
                        int x3 = x2 / x1;
                        stack.Push(x3);
                    }
                    else if (item == '%')
                    {
                        int x1 = int.Parse(stack.Pop().ToString());
                        int x2 = int.Parse(stack.Pop().ToString());
                        int x3 = x2 % x1;
                        stack.Push(x3);
                    }
                    else
                    {
                        int x1 = int.Parse(stack.Pop().ToString());
                        int x2 = int.Parse(stack.Pop().ToString());
                        double x3 = Math.Pow(x2, x1);
                        stack.Push(x3);
                    }
                }
                 
            }
           
            return stack.Pop().ToString();

        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            if (txttienTo.Text == "")
            {
                var s = txtTrungTo.Text;
                var tienTo = PrintScreenRessults(s);
                txtKq.Text = Expressions(tienTo);
            }
            else
            {
                var s = PrintScreenRessults(txttienTo.Text);
                txtKq.Text = Expressions(s);
            }
        }
    }
}
