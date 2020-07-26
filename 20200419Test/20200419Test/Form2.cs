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
    public partial class Form2 : Form
    {
        private string userId;
        public Form2(string userIdParam)
        {
            InitializeComponent();
            userId = userIdParam;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = userId;
            //获取当前时间
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();

        }

        private void 进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
