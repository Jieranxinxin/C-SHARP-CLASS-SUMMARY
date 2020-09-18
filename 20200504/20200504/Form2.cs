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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text==string.Empty)
            {
                MessageBox.Show("要写入的文件不能为空！");
            }
            else
            {
                //设置过滤器
                saveFileDialog1.Filter = "二进制文件（*.dat）|*.dat";
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    //输出流      FileAccess权限
                    FileStream myStream = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);
                    BinaryWriter myWriter = new BinaryWriter(myStream);
                    myWriter.Write(richTextBox1.Text);
                    //关流
                    myWriter.Close();
                    myStream.Close();
                    //清空一下，为下次做准备
                    richTextBox1.Text="";
                }
            }
        }
    }
}
