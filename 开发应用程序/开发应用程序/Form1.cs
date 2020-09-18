using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 开发应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //将button1的名字置空
            button1.Text = "";
            //在button1上加事件，使form2展示出来
            Form2 f2 = new Form2();
            f2.Show();
            //this.Hide();  form1隐藏
            //f2.Hide();form2闪一下，还在运行状态
            this.Close();//点一下按钮关掉  整个程序都关掉

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing");
        }
    }
}
