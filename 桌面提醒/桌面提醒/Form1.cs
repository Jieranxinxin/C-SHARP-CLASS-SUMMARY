using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 桌面提醒
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic_min_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pic_Colse_Click(object sender, EventArgs e)
        {
            //this.Close();
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
