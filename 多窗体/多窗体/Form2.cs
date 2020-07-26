using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多窗体
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //通过构造函数实现参数的传递
            Form3 f3 = new Form3(textBox1.Text,textBox2.Text);
            f3.Show();
            //隐藏
            //this.Hide();
        }
    }
}
