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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //先初始化，不加不显示
            listView1.View = View.Details;
            int width = listView1.Width / 4;
            listView1.Columns.Add("学号",width,HorizontalAlignment.Left);
            listView1.Columns.Add("姓名", width, HorizontalAlignment.Left);
            listView1.Columns.Add("性别", width, HorizontalAlignment.Left);
            listView1.Columns.Add("专业", width, HorizontalAlignment.Left);

        }

        private int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            listView1.Items.Add("row"+i,"1001",i);
            listView1.Items["row" + i].SubItems.Add("可可");
            listView1.Items["row" + i].SubItems.Add("男");
            listView1.Items["row" + i].SubItems.Add("软件");
            i++;
           // listView1.Items.Add("row1","1002","1");
        }
    }
}
