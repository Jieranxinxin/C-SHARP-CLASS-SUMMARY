using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageLIst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ToolStrip");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //整形转字符串
            toolStripStatusLabel1.Text = Convert.ToString(richTextBox1.Text.Length);
        }
    }
}
