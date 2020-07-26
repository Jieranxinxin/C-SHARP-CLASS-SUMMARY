using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 翻页
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();
        int pageSize = 2;//设置每页几条记录
        int page = 0;    //初始页数


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            page = 0;
            bindGird();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page = page - 1;
            bindGird();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page = page + 1;
            bindGird();
        }

        private int getCount()
        {
            int sum = linq.USERS1.Count();
            int s1 = sum / pageSize;
            int s2;
            if (sum % pageSize==0)
            {
                s2 = 0;
            }
            else
            {
                s2 = 1;
            }
            int count = s1 + s2;
            return count;
        }

        private void bindGird()
        {
            int pageIndex = page;
            //把整个看成一个对象     数据检索->Skip(pageSize * pageIndex)忽略那几条->Take(pageSize)再把那几条拿出来
            var result = (from info in linq.USERS1
                          select new
                          {
                              学号 = info.USERS1_ID,
                              姓名 = info.USERS1_NAME,
                              性别 = info.USERS1_SAX
                          }).Skip(pageSize * pageIndex).Take(pageSize);
            dataGridView1.DataSource = result;

            //让按钮初始化可用
            button1.Enabled = true;
            button2.Enabled = true;
            if (page==0)
            {
                button1.Enabled = false;
            }
            if (page ==getCount()-1)
            {
                button2.Enabled = false;
            }
        }
    }
}
