using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库连接
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stuId = textBox1.Text;
            string stuName = textBox2.Text;
            string stuSax = textBox3.Text;

            if (stuId == string.Empty || stuName == string.Empty || stuSax == string.Empty)
            {
                MessageBox.Show("输入内容不能为空！");
                return;
                //写了return可以接着往下写，否则下面的逻辑写到if()\else()
            }
           // "Data Source=.;Initial Catalog=Test;Integrated Security=True"
            string connectionStr = "Data Source=(local);DataBase=Test;Integrated Security=True";
            string insertStr = "INSERT INTO USERS1 VALUES("
           + "'" + stuId + "',"
           + "'" + stuName + "',"
           + "'" + stuSax + "')";

            try{
                using (SqlConnection connection=new SqlConnection(connectionStr))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = insertStr;
                    connection.Open();
                    //执行非查询语句
                    command.ExecuteNonQuery();
                    MessageBox.Show("新增数据成功！");

                }
                Form1 query = new Form1();
                query.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 query = new Form1();
            query.Show();
            this.Hide();
        }

       
    }
}
