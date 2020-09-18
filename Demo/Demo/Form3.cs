using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private Bitmap mybitmap;

        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(100, 100); //图片大小
            Graphics g = Graphics.FromImage(img);


            Pen pen = new Pen(Color.DimGray);
            SolidBrush brush = new SolidBrush(Color.YellowGreen);
            int height = 60;
            int vHeigth = 100;
            int vwidth = 30;
            for (int i = height; i > 0; i--)
                g.DrawEllipse(pen, 0, i, vHeigth, vwidth);

            g.FillEllipse(brush, 0, 0, vHeigth, vwidth);

            pictureBox2.Image = img;
            Draw(pictureBox1, 10);
        }

        private void Draw(PictureBox picbox, double sc)
        {
            mybitmap = new Bitmap(picbox.Width, picbox.Height);//设定位图大小
            Graphics g = Graphics.FromImage(mybitmap);//从位图上获取画布
            g.Clear(Color.White);//用背景色刷新
            //pictureBox1填充为白色，便于显示图像
            Rectangle rect = new Rectangle(0, 0, picbox.Width, picbox.Height);
            g.FillRectangle(new SolidBrush(Color.WhiteSmoke), rect);
            Pen pen = new Pen(Color.White, 2);//画笔
            Pen penline = new Pen(Color.White, 1);//画笔
            SolidBrush sb = new SolidBrush(Color.FromArgb(92, 0, 128));//标注画刷 
            int htmp = 18;

            g.DrawLine(pen, 20, picbox.Height - 25, (picbox.Width - 5) / 2, picbox.Height - 13);//绘制X斜下
            g.DrawLine(pen, (picbox.Width - 5) / 2, picbox.Height - 13, picbox.Width - 20, picbox.Height - 20);//绘制X斜上
            g.DrawLine(pen, 20, picbox.Height - 20, 20, 20);
            g.DrawLine(pen, 20, 20, (picbox.Width - 5) / 2, 20 + htmp);
            //中间竖线
            g.DrawLine(pen, (picbox.Width - 5) / 2, 20 + htmp, (picbox.Width - 5) / 2, picbox.Height - 20 + htmp);
            g.DrawLine(pen, (picbox.Width - 5) / 2, 20 + htmp, picbox.Width - 20, 20);
            g.DrawLine(pen, picbox.Width - 20, 20, picbox.Width - 20, picbox.Height - 20);
            //顶斜上
            g.DrawLine(pen, 20, 20, (picbox.Width - 5) / 2, 20 - htmp);
            //顶斜下
            g.DrawLine(pen, picbox.Width - 20, 20, (picbox.Width - 5) / 2, 20 - htmp); //底斜上
            g.DrawLine(pen, 20, picbox.Height - 20, (picbox.Width - 5) / 2, picbox.Height - 20 + htmp); //底部斜上
            //底部斜下
            g.DrawLine(pen, picbox.Width - 20, picbox.Height - 20, (picbox.Width - 5) / 2, picbox.Height - 20 - htmp);
            g.DrawLine(pen, 20, picbox.Height - 20, (picbox.Width - 5) / 2, picbox.Height - 20 - htmp); //斜下

            Brush top = new SolidBrush(Color.FromArgb(0, 100, 0));//顶部颜色
            Brush leftdown = new SolidBrush(Color.FromArgb(0, 150, 0));//左下颜色
            Brush rightdown = new SolidBrush(Color.FromArgb(100, 10, 100));//右下颜色
            Brush ns = new SolidBrush(Color.FromArgb(0, 250, 0)); //内部颜色 上矩形
            Brush nx = new SolidBrush(Color.FromArgb(250, 0, 100)); //内部颜色 下矩形

            Point[] p = new Point[4];
            p[0] = new Point(20, 20);
            p[1] = new Point((picbox.Width - 5) / 2, 20 - htmp);
            p[2] = new Point(picbox.Width - 20, 20);
            p[3] = new Point((picbox.Width - 5) / 2, 20 + htmp);
            g.FillPolygon(top, p);

            p[0] = new Point(20, 20);
            p[1] = new Point((picbox.Width - 5) / 2, 20 + htmp);
            p[2] = new Point((picbox.Width - 5) / 2, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)) + htmp);
            p[3] = new Point(20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));
            g.FillPolygon(top, p);

            //前左下
            p[0] = new Point(20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));
            p[1] = new Point((picbox.Width - 5) / 2, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)) + htmp);
            p[2] = new Point((picbox.Width - 5) / 2, picbox.Height - 20 + htmp);
            p[3] = new Point(20, picbox.Height - 20);
            g.FillPolygon(leftdown, p);

            //前右侧上
            p[0] = new Point((picbox.Width - 5) / 2, 20 + htmp);
            p[1] = new Point(picbox.Width - 20, 20);
            p[2] = new Point(picbox.Width - 20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));
            p[3] = new Point((picbox.Width - 5) / 2, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)) + htmp);
            g.FillPolygon(top, p);

            //右侧下
            p[0] = new Point((picbox.Width - 5) / 2, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)) + htmp);
            p[1] = new Point(picbox.Width - 20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));
            p[2] = new Point(picbox.Width - 20, picbox.Height - 20);
            p[3] = new Point((picbox.Width - 5) / 2, picbox.Height - 20 + htmp);
            g.FillPolygon(rightdown, p);

            //内侧两个矩形 上
            p[0] = new Point(20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));
            p[1] = new Point((picbox.Width - 5) / 2, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)) - htmp);
            p[2] = new Point(picbox.Width - 20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));
            p[3] = new Point((picbox.Width - 5) / 2, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)) + htmp);
            g.FillPolygon(ns, p);
            //内矩形 下
            p[0] = new Point(20, picbox.Height - 20);
            p[1] = new Point((picbox.Width - 5) / 2, picbox.Height - 20 - htmp);
            p[2] = new Point(picbox.Width - 20, picbox.Height - 20);
            p[3] = new Point((picbox.Width - 5) / 2, picbox.Height - 20 + htmp);
            g.FillPolygon(nx, p);

            //g.DrawLine(penline, (picbox.Width - 5) / 2, 20 + htmp, (picbox.Width - 5) / 2, picbox.Height - 20 + htmp);

            //g.DrawLine(penline, 20, 20, (picbox.Width - 5) / 2, 20 + htmp);

            //g.DrawLine(penline, (picbox.Width - 5) / 2, 20 + htmp, picbox.Width - 20, 20);

            //最后再来一个标注
            g.DrawString((sc * 100).ToString() + "%", new Font("宋体", 9), sb, picbox.Width - 20, 20 + Convert.ToInt32((picbox.Height - 20 - 20) * (1 - sc)));

            picbox.Image = mybitmap;

        }
    }
}
