using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.Items.Add("+");
            this.comboBox1.Items.Add("-");
            this.comboBox1.Items.Add("*");
            this.comboBox1.Items.Add("/");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 1;
            double b = 1;
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            if (s1 != null)
            {
                a = Convert.ToDouble(s1);
            }
            if (s2 != null)
            {
                b = Convert.ToDouble(s2);
            }
            switch (comboBox1.SelectedItem.ToString()) //获取选择的内容
            {
                case "+": textBox3.Text=Convert.ToString(a+b); break;
                case "-": textBox3.Text = Convert.ToString(a - b); break;
                case "*": textBox3.Text = Convert.ToString(a * b); break;
                case "/": textBox3.Text = Convert.ToString(a / b); break;
            }
        }
    }
}
