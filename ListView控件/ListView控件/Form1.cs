using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        #region 添加表头列
        private void button1_Click(object sender, EventArgs e)
        {
            //专放表头   表头的第一列
            //加列用Columns
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "学号";
            //向哪居中
            ch.TextAlign = HorizontalAlignment.Left;
            ch.Width = listView1.Width / 4;
            //将这个表头加入listView1里
            listView1.Columns.Add(ch);

            listView1.Columns.Add("姓名", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("性别", listView1.Width / 4, HorizontalAlignment.Left);
            listView1.Columns.Add("专业", listView1.Width / 4, HorizontalAlignment.Left);
            //使这个button1不可用
            button1.Enabled = false;

        }
        #endregion

        #region 添加数据行
        private void button2_Click(object sender, EventArgs e)
        {
            //加行用Items  ("这一行的代号"，"填入的值"，"索引")
            listView1.Items.Add("row1","1001",0);
            listView1.Items["row1"].SubItems.Add("新新");
            listView1.Items["row1"].SubItems.Add("女");
            listView1.Items["row1"].SubItems.Add("软件技术");

            listView1.Items.Add("row2", "1002", 1);
            listView1.Items["row2"].SubItems.Add("可可");
            listView1.Items["row2"].SubItems.Add("女");
            listView1.Items["row2"].SubItems.Add("软件技术");

            listView1.Items.Add("row3", "1003", 2);
            listView1.Items["row3"].SubItems.Add("小明");
            listView1.Items["row3"].SubItems.Add("男");
            listView1.Items["row3"].SubItems.Add("软件技术");

            //循环加颜色
            for (int i=0; i<listView1.Items.Count;i++) 
            {
                if (i % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.AliceBlue;
                }
            
            }
        }

        #endregion

        #region 删除属性列
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Columns.Count == 0)
            {
                MessageBox.Show("已删除全部，不可再进行删除");
            }
            else {
                listView1.Columns.Remove(listView1.Columns[0]);
            }
        }

        #endregion

        #region 删除数据项
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("此时数据项为0，不可在进行删除");
            }
            else {
                listView1.Items.Remove(listView1.Items[0]);
            }
        }

        #endregion

        #region 清空数据项
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        #endregion

        #region  全部清空
        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }
        #endregion
    }
}
