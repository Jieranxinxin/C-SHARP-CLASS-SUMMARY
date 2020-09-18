using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq
{
    public partial class 增删改 : Form
    {
        public 增删改()
        {
            InitializeComponent();
        }
        DataClasses1DataContext linq = new DataClasses1DataContext();
        string connectionStr = "Data Source=(local);Database=Test;Integrated Security=true";


        private void button1_Click(object sender, EventArgs e)
        {
            //linq每个都要实例化
            linq = new DataClasses1DataContext(connectionStr);
            USERS1 user = new USERS1();
            user.USERS1_ID = textBox1.Text;
            user.USERS1_NAME = textBox2.Text;
            user.USERS1_SAX = textBox3.Text;

            linq.USERS1.InsertOnSubmit(user);
            MessageBox.Show("新增成功！");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1.找数据
            linq = new DataClasses1DataContext(connectionStr);
            //linq表达式
            //用info遍历USERS1
            var result = from info in linq.USERS1
                            where info.USERS1_ID == textBox1.Text
                            select info;
            //2.遍历修改
            foreach (USERS1 user in result)
            {
                user.USERS1_ID = textBox1.Text;
                user.USERS1_NAME = textBox2.Text;
                user.USERS1_SAX = textBox3.Text;
                linq.SubmitChanges();

            }
            MessageBox.Show("数据修改成功！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            linq = new DataClasses1DataContext(connectionStr);
            var result = from info in linq.USERS1
                            where info.USERS1_ID == textBox1.Text
                            select info;
            linq.USERS1.DeleteAllOnSubmit(result);
            //提交改变
            linq.SubmitChanges();
            MessageBox.Show("删除成功！");
        }

    }
}