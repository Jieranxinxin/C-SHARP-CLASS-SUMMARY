using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文件复制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sourceFilePath="";
        //规定一个线程
        private Thread thdAddFile;



        private void button1_Click(object sender, EventArgs e)
        {
            //表示窗口关闭后返回copy一个窗口的结果
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret==DialogResult.OK)
            {
                //选择具体的文件
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret = folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                //选择文件夹的路径
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("文件路径不可为空！");
                return;
            }

            sourceFilePath = textBox1.Text;
            //"\"需要转移一下
            sourceFilePath = "\\"+sourceFilePath.Substring(sourceFilePath.LastIndexOf("\\") + 1,
                sourceFilePath.Length-sourceFilePath.LastIndexOf("\\")-1);

            //new Thread(new ThreadStart(要启动的线程));
            thdAddFile = new Thread(new ThreadStart(setAddFile));
            //启动线程
            thdAddFile.Start();

        }

        //写一个委托，让委托去完成对线程的操作
        public delegate void AddFile();
        public void setAddFile()
        {
            //启动一下委托
            this.Invoke(new AddFile(RunAddFile));
        }

        public void RunAddFile()
        {
            //启动线程之后要做的操作
            CopyFile(1024);
            //关线程
            thdAddFile.Abort();
        }
        public void CopyFile(int sectSize)
        {
            //创建文件
            string sourceFile = textBox1.Text;
            string targetFile = textBox2.Text;
            targetFile = targetFile + sourceFilePath;
            FileStream fileToCream = new FileStream(targetFile, FileMode.Create);
            //在释放掉
            fileToCream.Close();
            fileToCream.Dispose();

            //读    源文件     打开的模式    FileAccess.Read权限
            FileStream sourceFileOpen = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            //写     FileMode.Append起到覆盖的左右
            FileStream targeFileOpen = new FileStream(targetFile, FileMode.Append, FileAccess.Write);

            //先取一下文件流的长度
            //进度条传值，一、分节传递  二、整体传递
            //max份数分了多少节
            //Math.Ceiling向上取整
            int max = Convert.ToInt32(Math.Ceiling((double)sourceFileOpen.Length / (double)sectSize));
            //当前值
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = max;

            //规定文件当前copy多少，在这个基础上累加
            int fileSize = 0;
            //判断怎么复制    传递的字节和整体的宽度  小分节copy
            if(sectSize<sourceFileOpen.Length){
                //定义字节流
                byte[] buffur = new byte[sectSize];
                //专放copy了多少
                int copied = 0;
                //进度条每次走的长度
                int tem_n = 1;

                //已经copy过的长度  小于  总长度-最后一节的长度  因为向上取整，所以sectSize是偏小的
                //可以整除的
                while (copied<=((int)sourceFileOpen.Length-sectSize))
                {
                    fileSize = sourceFileOpen.Read(buffur, 0, sectSize);
                    //清空一下
                    sourceFileOpen.Flush();
                    targeFileOpen.Write(buffur, 0, sectSize);
                    targeFileOpen.Flush();
                    copied += fileSize;
                    progressBar1.Value += tem_n;
                }
                //不可以整除的
                int left=(int)sourceFileOpen.Length - copied;
                sourceFileOpen.Read(buffur,0,left);
                sourceFileOpen.Flush();
                targeFileOpen.Write(buffur,0,left);
                targeFileOpen.Flush();
            }
            else
            {
                byte[] buffer = new byte[sourceFileOpen.Length];
                sourceFileOpen.Read(buffer, 0, (int)sourceFileOpen.Length);
                sourceFileOpen.Flush();
                targeFileOpen.Write(buffer, 0, (int)sourceFileOpen.Length);
                targeFileOpen.Flush();
            }

            //关字节流
            sourceFileOpen.Close();
            targeFileOpen.Close();

            //DialogResult返回值
            DialogResult ret =MessageBox.Show("复制完成","信息提示",MessageBoxButtons.OK);
            if (ret==DialogResult.OK)
            {
                progressBar1.Value = 0;
                textBox1.Text = "";
                textBox2.Clear();
                sourceFilePath = "";
            }
        }
    }
}
