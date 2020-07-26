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
    public partial class 查 : Form
    {
        public 查()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=(local);Database=Test;Integrated Security=true";
            //创建linq对象    操作的connectionStr数据库
            DataClasses1DataContext linq = new DataClasses1DataContext(connectionStr);

            var result = from info in linq.USERS1
                         select new
                         {
                             学号 = info.USERS1_ID,
                             姓名 = info.USERS1_NAME,
                             性别=info.USERS1_SAX
                         };
            dataGridView1.DataSource = result;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            增删改 form = new 增删改();
            form.Show();
            this.Hide();
        }
    }
}
