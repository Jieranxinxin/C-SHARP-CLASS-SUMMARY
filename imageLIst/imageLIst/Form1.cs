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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void help_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Right < 0)
            {
                pictureBox1.Left = this.Width;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;//进度条的最小值
            progressBar1.Maximum = 500;//进度条的最大值
            progressBar1.Value = 0;//当前值
            progressBar1.Visible = true;//此乃默认值

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;//让其重新为0，继续循环
            for (int i = 0; i < 500; i++)
            {
                progressBar1.Value++;
                Application.DoEvents();
            }
        }
    }
}
