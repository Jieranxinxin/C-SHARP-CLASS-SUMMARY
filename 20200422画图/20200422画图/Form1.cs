using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200422画图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics类  里面包含画图的几乎所有用法  一个画布
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            //用这个来画线
            //第一种写法
            //(pen,第一个点坐标，第二个点坐标)
            //g.DrawLine(pen,50,50,350,50);
            //第二种写法
            Point p1 = new Point(50,50);
            Point p2 = new Point(350,50);
            g.DrawLine(pen,p1,p2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Graphics类  里面包含画图的几乎所有用法  一个画布
            Graphics g = this.CreateGraphics();
            //(颜色，宽度)
            Pen pen = new Pen(Color.Red,5);
            //第一种方法
            //（左上角点的坐标，长，宽）
            //g.DrawRectangle(pen,50,50,300,50);

            //第二种方法
            //声明一个矩形
            Rectangle rect = new Rectangle( 50, 50, 300, 50);
            g.DrawRectangle(pen,rect);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.BlueViolet);
            Rectangle r = new Rectangle(50, 50, 300, 50);
            g.FillRectangle(brush,r);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue,4);
            //Brush brush = new SolidBrush(Color.LightYellow);
            Rectangle rectangle = new Rectangle(50, 50, 300, 50);
            //画个圆   正方形->圆  长方形->椭圆
            g.DrawEllipse(pen, rectangle);
           // g.FillEllipse(brush,rectangle);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue, 4);
            Brush brush = new SolidBrush(Color.LightYellow);
            Rectangle rectangle = new Rectangle(50, 50, 300, 50);
            //画个圆   正方形->圆  长方形->椭圆
            g.DrawEllipse(pen, rectangle);
            g.FillEllipse(brush, rectangle);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue, 4);
            Rectangle rectangle = new Rectangle(50, 50, 200, 200);
            //(Pen,范围（矩形），开始的角度，这个弧的角度)
            g.DrawArc(pen,rectangle,90,90);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue, 4);
            Brush brush = new SolidBrush(Color.Blue);
            Rectangle rectangle = new Rectangle(50, 50, 200, 200);
            g.FillPie(brush,rectangle,0,30);
            //重新实例化
            brush = new SolidBrush(Color.Red);
            g.FillPie(brush,rectangle,30,180);
            brush = new SolidBrush(Color.Black);
            g.FillPie(brush, rectangle, 210, 150);

        }
    }
}
