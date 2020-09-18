using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangle_and_cylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.SeaGreen);
            Pen pen1 = new Pen(Color.SeaGreen);
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Point p1 = new Point(50,100);
            Point p2 = new Point(80,70);
            Point p3 = new Point(150, 100);
            Point p4 = new Point(180,70);
            Point p5 = new Point(50, 140);
            Point p6 = new Point(80, 110);
            Point p7 = new Point(150, 140);
            Point p8 = new Point(180, 110);

            Rectangle rectangle = new Rectangle(50,100,100,40);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen,p3,p4);
            g.DrawLine(pen1,p5,p6);
            g.DrawLine(pen ,p7,p8);
            g.DrawLine(pen,p2,p4);
            g.DrawLine(pen,p4,p8);
            g.DrawLine(pen1,p2,p6);
            g.DrawLine(pen1,p6, p8);
            g.DrawRectangle(pen, rectangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.SeaGreen);
            int wide = 40;
            int long1 = 100;
            int x = 350;
            int y1 = 50;
            int y2 = 150;
            Rectangle rectangle = new Rectangle(x,y2,long1,wide);
            Rectangle rectangle1 = new Rectangle(x, y1, long1, wide);
            g.DrawEllipse(pen,rectangle);
            g.DrawEllipse(pen,rectangle1);
            Point p1 = new Point(x,y1+wide/2);
            Point p2 = new Point(x,y2+wide/2);
            Point p3 = new Point(x + long1, y1 + wide / 2);
            Point p4 = new Point(x+long1, y2 + wide / 2);
            g.DrawLine(pen,p1, p2);
            g.DrawLine(pen,p3,p4);

        }
    }
}
