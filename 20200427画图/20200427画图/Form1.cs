using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200427画图
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
            g.Clear(Color.White);

            //填充矩形
            Brush b = new SolidBrush (Color.AliceBlue);
            int width = this.Width;
            int height = this.Height;
            Rectangle r = new Rectangle(0,0,width,height);
            g.FillRectangle(b,r);

            //声明一下标题，提示内容
            Brush b1 = new SolidBrush(Color.LimeGreen);
            Font font = new Font("微软雅黑", 18, FontStyle.Bold);
            Font font1 = new Font("微软雅黑",10,FontStyle.Regular);
            //Y用DrawString  方法把字打出
            //坐标可以这样写：
            //Point point = new Point(70,20);
            //也可以直接new 一个
            g.DrawString("每月商品占比饼状图",font,b1,new Point(30,20));

            //对数值的初始化
            int[] saleNum = { 300, 500, 400 };
            int sum = 0;
            int threeNum =0;
            int fourNum = 0;
            int fiveNum = 0;
            for (int i=0; i < saleNum.Length; i++)
            {
                sum += saleNum[i];
                if (i == 0)
                {
                    threeNum = saleNum[0];
                }
                if (i == 1)
                {
                    fourNum = saleNum[1];
                }
                if (i == 2)
                {
                    fiveNum = saleNum[2];
                }
            }
            //MessageBox.Show(Convert.ToString(threeNum));

            //当然也可以直接赋值
            //int threeNum = 300;
            //int fourNum = 400;
            //int fiveNum = 500;

            //角度：360=月销量：总销量
            //强转一下数据类型  ToSingle   返回单精度浮点数
            float angle1 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(threeNum));
            float angle2 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(fourNum));
            float angle3 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(fiveNum));
            //MessageBox.Show(Convert.ToString(angle2));

            //画饼图
            int piex = 30;
            int piey = 80;
            int piew = 200;
            int pieh = 200;

            Brush b2 = new SolidBrush(Color.Red);
            Brush b3 = new SolidBrush(Color.LightYellow);
            Brush b4 = new SolidBrush(Color.BlueViolet);

            Rectangle r1 = new Rectangle(piex,piey,piew,pieh);
            g.FillPie(b2, r1, 0, angle1);
            g.FillPie(b3,r1,angle1,angle2);
            //第三个参数是起始角度
            g.FillPie(b4,r1, angle1+angle2, angle3);

            
            Pen pen1 = new Pen(Color.Red);
            //画一个矩形
            g.DrawRectangle(pen1,260,90,270,100);
            //图例
            g.FillRectangle(b2, 270, 100, 30, 20);
            //展示出的字样    Format参数一个格式化字符串  此处  格式化百分比  {0:P2}小数点后保留两位
            g.DrawString(string.Format("三月份销量占比：{0:P2}", Convert.ToSingle(threeNum) / Convert.ToSingle(sum)), font1, b2, 350, 100);
            g.FillRectangle(b3, 270, 130, 30, 20);
            g.DrawString(string.Format("四月份销量占比：{0:P2}", Convert.ToSingle(fourNum) / Convert.ToSingle(sum)), font1, b3, 350, 130);
            g.FillRectangle(b4, 270, 160, 30, 20);
            g.DrawString(string.Format("五月份销量占比：{0:P2}", Convert.ToSingle(fiveNum) / Convert.ToSingle(sum)), font1, b4, 350, 160);
        }
    }
}
