using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace 表白
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        public Form1()
        {
            InitializeComponent();
        }
        #region 属性
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        string name, QQ, imagef = "", musicPath, sex = "小姐姐";
        int affect = 0;
        #endregion
        #region 初始化窗口
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30;
            timer2.Interval = 10;
            timer1.Enabled = true;
            timer2.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;
            label13.Visible = false;
            label15.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            this.ShowInTaskbar = false;
            radioButton2.Checked = true;
            this.Opacity = 1;
            numericUpDown1.Minimum = DateTime.Now.Hour; numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Minimum = DateTime.Now.Minute; numericUpDown2.Value = DateTime.Now.Minute;
            numericUpDown3.Minimum = DateTime.Now.Second; numericUpDown3.Value = DateTime.Now.Second;

        }
        #endregion
        #region 单选按钮处理
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sex = "小哥哥";
                textBox3.Text = "小哥哥，我喜欢你很久了";
                textBox5.Text = "你英俊潇洒  知书达理";
                textBox7.Text = "小哥哥，做我男朋友好不好?";
                textBox10.Text = "小哥哥，我会对你好的!";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sex = "小姐姐";
                textBox3.Text = "小姐姐，我喜欢你很久了";
                textBox5.Text = "你温柔贤惠  知书达理";
                textBox7.Text = "小姐姐，做我女朋友好不好?";
                textBox10.Text = "小姐姐，我会对你好的!";
            }
        }
        #endregion  
        #region 自定义标题栏---窗口的移动
        Point mPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                this.Location = new Point(MousePosition.X - mPoint.X, MousePosition.Y - mPoint.Y);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                mPoint = (this.PointToClient(MousePosition));
            }
        }
        #endregion
        #region 单击二维码图片框时
        //单击图片框后
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "jpg文件(*.jpg)png文件(*.png)bmp文件(*.bmp)GIF文件(*.GIF)|*.jpg;*.png;*.bmp;*.GIF";
            open.ShowDialog();
            imagef = open.FileName;//保存路径
            if (imagef != "")
            {
                pictureBox2.BackgroundImage = Image.FromFile(imagef);
                label13.Visible = true;
            }
            open.Dispose();
        }

        #endregion
        #region 单击音乐图片框时
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "mp3文件(*.mp3)flac文件(*.flac)wma文件(*.wma)wav文件(*.wav)|*.mp3;*.flac;*.wma;*.wav";
            open.ShowDialog();

            musicPath = open.FileName;//保存路径
            open.Dispose();
        }

        #endregion
        #region 单击返回图片框时
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = true;
        }

        #endregion
        #region 单击设置图片框时
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
        }
        #endregion
        #region 关闭按钮处理
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (affect == 0)
                this.Close();
            else if (affect == 1) { notifyIcon1.ShowBalloonTip(0, "您好", "窗口已隐藏", ToolTipIcon.Info); this.Hide(); }
            else
            {
                form2.BackgroundImage = global::表白.Properties.Resources._666;
            }
        }
        int s = 0;
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (affect == 0)
                pictureBox1.BackgroundImage = global::表白.Properties.Resources._96u58PICdEY;
            if (affect == 3)
            {
                if (s > 2) s = 0;
                pictureBox1.BackgroundImage = global::表白.Properties.Resources._96u58PICdEY;
                switch (s)
                {
                    case 0:
                        form3.label1.Text = sex + "，不要关了我";
                        form3.Show(); break;
                    case 1:
                        form3.label1.Text = sex + "，你又调皮了";
                        form3.Show(); break;
                    case 2:
                        form3.label1.Text = "---" + sex + "，你这样我会很伤心的----";
                        form3.Show(); break;
                }
                s++;
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (affect == 0)
                pictureBox1.BackgroundImage = global::表白.Properties.Resources._0006019748618084_b;
            if (affect == 3)
                pictureBox1.BackgroundImage = global::表白.Properties.Resources._0006019748618084_b;
        }
        #endregion
        #region 使窗口有呼吸效果和自动切换背景图片
        int a = 0, b = 0; double num = 0; bool ps = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ps)
            {
                if (num > 1)
                {
                    ps = false; if (a > 9) a = 0;
                    switch (a)
                    {
                        case 0: label1.Text = textBox3.Text; this.BackgroundImage = global::表白.Properties.Resources._000; break;
                        case 1: label1.Text = textBox4.Text; this.BackgroundImage = global::表白.Properties.Resources._001; break;
                        case 2: label1.Text = textBox5.Text; this.BackgroundImage = global::表白.Properties.Resources._002; break;
                        case 3: label1.Text = textBox6.Text; this.BackgroundImage = global::表白.Properties.Resources._003; break;
                        case 4: label1.Text = textBox7.Text; this.BackgroundImage = global::表白.Properties.Resources._004; break;
                        case 5: label1.Text = textBox8.Text; this.BackgroundImage = global::表白.Properties.Resources._005; break;
                        case 6: label1.Text = textBox9.Text; this.BackgroundImage = global::表白.Properties.Resources._006; break;
                        case 7: label1.Text = textBox10.Text; this.BackgroundImage = global::表白.Properties.Resources._007; break;
                        case 8: label1.Text = textBox11.Text; this.BackgroundImage = global::表白.Properties.Resources._008; break;
                        case 9: label1.Text = textBox6.Text; this.BackgroundImage = global::表白.Properties.Resources._009; break;
                    }
                    a++;
                    label1.ForeColor = Color.Cyan;
                }
                this.Opacity = num;
                num += 0.01;
            }
            else
            {
                if (num < 0.4)
                {
                    ps = true;
                    if (b > 4) b = 0;
                    switch (b)
                    {
                        case 0:
                            if (sex == "小姐姐")
                                form2.BackgroundImage = global::表白.Properties.Resources._01;
                            else if (sex == "小哥哥")
                                form2.BackgroundImage = global::表白.Properties.Resources._2018032010363798224; break;
                        case 1: form2.BackgroundImage = global::表白.Properties.Resources._02; break;
                        case 2: form2.BackgroundImage = global::表白.Properties.Resources._03; break;
                        case 3: form2.BackgroundImage = global::表白.Properties.Resources._04; break;
                        case 4:
                            if (sex == "小姐姐") form2.BackgroundImage = global::表白.Properties.Resources._05;
                            else if (sex == "小哥哥")
                                form2.BackgroundImage = global::表白.Properties.Resources._2018032010363866154; break;
                    }
                    b++;
                    label1.ForeColor = Color.White;
                }
                this.Opacity = num;
                num -= 0.01;
            }
        }
        #endregion
        #region 确定键
        private void label4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            pictureBox1.BackgroundImage = global::表白.Properties.Resources.minimize_box_blue;
            name = textBox19.Text;
            QQ = textBox20.Text;
            label10.Location = new Point(120, 85);
            label8.Location = new Point(120, 120);
            If_Start_Time = true;
            first_dowm_time = Convert.ToInt32((numericUpDown1.Value - DateTime.Now.Hour) * 3600 + (numericUpDown2.Value - DateTime.Now.Minute) * 60 + (numericUpDown3.Value - DateTime.Now.Second));
            affect = 1;
        }
        #endregion
        #region 子窗口2的处理
        int L = 0, v0 = 10, posIf = 0;
        bool lable8_show = true, If_Start_Time = false;
        public int time_dowm = 10, first_dowm_time = 10;

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        private void label13_Click(object sender, EventArgs e)
        {
            imagef = "";
            pictureBox2.BackgroundImage = null;
            label13.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lable8_show)
            {
                if (If_Start_Time)
                {
                    #region 当倒计时时间到时，初始化
                    if (time_dowm == 0)
                    {
                        lable8_show = false;
                        form2.Show();
                        timer2.Enabled = true;
                        affect = 3;
                        this.Opacity = 0;
                        button1.Text = "好";
                        button2.Text = "不好";
                        button1.Visible = true;
                        button2.Visible = true;
                        label1.Text = textBox3.Text; this.BackgroundImage = global::表白.Properties.Resources._001;
                        pictureBox1.BackgroundImage = global::表白.Properties.Resources._0006019748618084_b;
                        form2.BackgroundImage = global::表白.Properties.Resources._03;
                        if (musicPath != "")
                            axWindowsMediaPlayer1.URL = musicPath;
                        panel4.Visible = false;
                        this.Show();

                    }
                    #endregion
                    time_dowm = Convert.ToInt32((numericUpDown1.Value - DateTime.Now.Hour) * 3600 + (numericUpDown2.Value - DateTime.Now.Minute) * 60 + (numericUpDown3.Value - DateTime.Now.Second));
                    label9.Text = "剩余秒数" + time_dowm;
                }
                numericUpDown1.Minimum = DateTime.Now.Hour;

                numericUpDown2.Minimum = DateTime.Now.Minute;
                numericUpDown3.Minimum = DateTime.Now.Second;
                label8.Text = "" + DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
            }
            else
            {
                #region  子窗口2的移动
                switch (posIf)
                {
                    case 0:     //判断子窗口位置是否超过父窗口的最右边
                        if (form2.Left >= this.Right) { posIf++; L = 0; }
                        else
                        {          //字窗口位置紧贴父窗口并向右移动
                            form2.Left = this.Left + L;
                            form2.Top = this.Top - (form2.Height);
                            L += v0;
                        }
                        break;
                    case 1:     //判断子窗口位置是否超过父窗口的最下边
                        if (form2.Top >= this.Bottom) { posIf++; L = 0; }
                        else
                        {//字窗口位置紧贴父窗口并向下移动
                            form2.Left = this.Right;
                            form2.Top = this.Top - form2.Height + L;
                            L += v0;
                        }
                        break;
                    case 2:     //判断子窗口位置是否超过父窗口的最左边+子窗口的宽度
                        if (form2.Right <= this.Left) { posIf++; L = 0; }
                        else
                        {//字窗口位置紧贴父窗口并向左移动
                            form2.Left = this.Right - L;
                            form2.Top = this.Bottom;
                            L += v0;
                        }
                        break;
                    case 3:     //判断子窗口位置是否超过父窗口的最上边+子窗口的高度
                        if (form2.Bottom <= this.Top) { posIf = 0; L = 0; }
                        else
                        {//字窗口位置紧贴父窗口并向上移动
                            form2.Left = this.Left - form2.Width;
                            form2.Top = this.Bottom - L;
                            L += v0;
                        }
                        break;
                }
                #endregion
            }
        }
        #endregion
        #region 按钮1，按钮2处理
        int buttonText_Null = 0;
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (buttonText_Null < 4)
                if (button2.Text == "不好")
                {
                    button1.Text = "不好";
                    button2.Text = "好";
                    buttonText_Null++;
                }
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (buttonText_Null < 4)
                if (button1.Text == "不好")
                {
                    button1.Text = "好";
                    button2.Text = "不好";
                    buttonText_Null++;
                }
        }
        Image image;
        public void button_(string buttonText)      //按钮事件处理函数
        {
            if (buttonText == "好")
            {
                image = global::表白.Properties.Resources._0011;
                image.Save("D:\\AAA.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, "D:\\AAA.bmp", 0x2);    //设置桌面壁纸---不保存
                button1.Visible = false;        //button1隐藏
                button2.Visible = false;        //button2隐藏
                timer1.Enabled = false;        //定时器1停止      
                timer2.Enabled = false;         //定时器2停止
                this.Opacity = 1;
                affect = 0;
                label1.Visible = false;
                label15.Visible = true;
                label15.Text = "-----" + sex + "，你人真好-----";
                form2.label1.Text = "我的名字:" + name;
                form2.label2.Text = "QQ" + QQ;
                form2.Height = 100;
                form2.Width = this.Width;
                form2.Location = new Point(this.Left, this.Top - form2.Height);
                form2.BackgroundImage = null;
                if (imagef != "")
                    this.BackgroundImage = Image.FromFile(imagef);        //显示二维码             
            }
            else
            {
                button2.Text = "好";             //修改button2的文本
                form3.label1.Text = sex + "，你是不是选错了?";
                form3.Show();

                image = global::表白.Properties.Resources._666;
                image.Save("D:\\BBB.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, "D:\\BBB.bmp", 0x2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button_(button1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button_(button2.Text);
        }
        #endregion
    }
}

        }
    }
}
