using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200419Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty||textBox2.Text==string.Empty)
            {
                MessageBox.Show("用户名和密码都不能为空！","信息提示",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if(textBox1.Text=="admin"&&textBox2.Text=="1234")
            {
                Form2 f2 = new Form2(textBox1.Text);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码不正确！", "信息提示", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void 重置_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
