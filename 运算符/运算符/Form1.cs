using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 运算符
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = a + b;
            textBox3.Text =Convert.ToString(c);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox6.Text);
            int b = Convert.ToInt32(textBox5.Text);
            int c = a - b;
            textBox4.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox9.Text);
            int b = Convert.ToInt32(textBox8.Text);
            int c = a * b;
            textBox7.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox12.Text);
            int b = Convert.ToInt32(textBox11.Text);
            if (b!=0)
            {
                double c = a / b;
                textBox10.Text = Convert.ToString(c);
            }
            else
            {
                MessageBox.Show("除数不可为0！", "信息提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
