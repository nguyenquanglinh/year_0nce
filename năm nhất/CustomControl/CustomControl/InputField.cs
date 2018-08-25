using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class InputField : UserControl
    {


        public int Value
        {
            get
            {
                int v = 0;
                if (!int.TryParse(textBox1.Text, out v))
                    return 0;
                return int.Parse(textBox1.Text);
            }
        }

        string customText;
        public string CustomText
        {
            get { return customText; }
            set
            {
                customText = value;
                this.label1.Text = value;
            }
        }

        public InputField()
        {
            InitializeComponent();
            this.textBox1.KeyPress += textBox1_KeyPress;
        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-')
                return;

            e.Handled = true;
        }

    }
}
