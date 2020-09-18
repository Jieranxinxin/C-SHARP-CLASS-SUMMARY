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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("一个参数的提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("两个参数的提示","信息提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("三个参数的提示", "信息提示",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("您选择了是");
            }
            else
            {
                MessageBox.Show("您选择了否");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("三个参数的提示", "信息提示", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("您选择了是");
            }
            else if(dr==DialogResult.No)
            {
                MessageBox.Show("您选择了否");
            }
            else
            {
                MessageBox.Show("您选择了取消");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //第一种方式
            //f2.Show();
            //第二种方式
            //f2.ShowDialog();
            //区别ShowDialog 会阻止你去点下面的窗体

            //先确认路径  \转义或者在路径前面加@
            openFileDialog1.InitialDirectory = @"C:\Users\孑然\Pictures\Saved Pictures";//@"D:\Code"
            //设置过滤器
            openFileDialog1.Filter = "C#文件|*.cs";
            openFileDialog1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //定义过滤器
            saveFileDialog1.Filter = "C#文件|*.cs";
            saveFileDialog1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //将textBox1.Text赋值，赋的值是传入的路径
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox2.ForeColor = colorDialog1.Color;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox3.Font = fontDialog1.Font;
        }
    }
}
