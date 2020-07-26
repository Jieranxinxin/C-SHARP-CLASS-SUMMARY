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

namespace 文件夹
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = @"D:\Learning\TestFile\path";
        string target_path = @"D:\Learning\TestFile\target_path\path";

        private void button1_Click(object sender, EventArgs e)
        {

            //DirectoryInfo di = new DirectoryInfo(path);
            //但是di没有CreateDirectory（），但是有Create（）

            Directory.CreateDirectory(path);
            MessageBox.Show("创建文件夹成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    //判断子文件夹     子文件GetFiles    子文件夹 GetDirectories 
                    if (Directory.GetFiles(path).Length==0&&Directory.GetDirectories(path).Length==0)
                    {
                        Directory.Delete(path);
                        MessageBox.Show("删除成功");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("删除文件夹失败"+ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("源文件不存在");
            }else if(Directory.Exists(target_path)){
                MessageBox.Show("目标文件夹里已存在需要移动的文件");
            }else if (!Directory.Exists(target_path))
            {
                Directory.Move(path,target_path);
                MessageBox.Show("移动成功");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString( Directory.GetCreationTime(path));
        }

    }
}
