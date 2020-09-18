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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Changed");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyValue ==13
            if (e.KeyCode==Keys.Enter) {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登录成功");
        }
    }
}
