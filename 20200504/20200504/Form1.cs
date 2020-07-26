using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text =@"D:\Learning\TestFile\1.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (path=="")
            {
                MessageBox.Show("路径为空！");
                //一定要加return否则会向下执行，path还是空
                return;
            }

            //定义一个变量
            FileMode fileM = FileMode.Open;
            if (radioButton1.Checked==true)
            {
                fileM = FileMode.Open;
            }
            if (radioButton4.Checked == true)
            {
                fileM = FileMode.Append;
            }
            if (radioButton2.Checked == true)
            {
                fileM = FileMode.Truncate;
            }
            if (radioButton3.Checked == true)
            {
                fileM = FileMode.Create;
            }

            try
            {
                using (FileStream fs = File.Open(path, fileM))
                {
                    if (fileM != FileMode.Truncate) 
                    { 
                        //转一下码   GetBytes(textBox2.Text);   里面是写入的内容
                        Byte[] info = new UTF8Encoding(true).GetBytes(textBox2.Text);
                        //Write(Byte[],起始，长度);
                        fs.Write(info, 0, info.Length);
                    }
                    else
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("");
                        fs.Write(info, 0, info.Length);
                    }
                }
                //写完之后读一下，来检验是否写进去
                using (FileStream fs=File.Open(path,FileMode.Open))
                {
                    //二进制数组规定长度
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    string outPutStr = "";
                    while (fs.Read(b,0,b.Length)>0)
                    {
                        outPutStr += temp.GetString(b);
                    }
                    MessageBox.Show(outPutStr);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
