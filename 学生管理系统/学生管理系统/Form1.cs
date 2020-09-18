using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty){
                MessageBox.Show("用户名和密码都不能为空！","信息提示",MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }else if(textBox1.Text=="user"&&textBox2.Text=="111"){
                Form2 f2 = new Form2(string.Empty, string.Empty, string.Empty, string.Empty);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！","信息提示",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
