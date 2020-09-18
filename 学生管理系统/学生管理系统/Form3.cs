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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string stuId = textBox1.Text;
            string stuName = textBox2.Text;
            string stuClass = textBox3.Text;
            string stuMajor = textBox4.Text;
            Form2 f2 = new Form2(stuId, stuName, stuClass, stuMajor);
            
            MessageBox.Show("保存成功！");
            f2.Show();
            this.Hide();
        }
    }
}
