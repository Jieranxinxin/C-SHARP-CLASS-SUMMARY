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
    public partial class Update : Form
    {
        public Update(string stuIdParam)
        {
            InitializeComponent();

            //将主键设成灰色，禁止用户更改
            textBox1.Enabled = false;

            //连接数据库
            string connectionStr = "Data Source=(local);DataBase=Test;Integrated Security=True";
            string queryStr = "SELECT USERS1_ID,USERS1_NAME,USERS1_SAX FROM USERS1 WHERE USERS1_ID='"
                + stuIdParam + "'";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = queryStr;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //遍历出来
                    while (reader.Read())
                    {
                        //列   将主键所对应的显示出来
                        textBox1.Text = Convert.ToString(reader[0]);
                        textBox2.Text = Convert.ToString(reader[1]);
                        textBox3.Text = Convert.ToString(reader[2]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stuId = textBox1.Text;
            string stuName = textBox2.Text;
            string stuSax = textBox3.Text;

            string connectionStr = "Data Source=(local);DataBase=Test;Integrated Security=True";
            string updateStr = "UPDATE USERS1 SET USERS1_NAME= '" +stuName + "'," +
                "USERS1_SAX ='" + stuSax +
                "'WHERE USERS1_ID='"+ stuId+"'";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = updateStr;
                    connection.Open();
                    //执行非查询语句
                    command.ExecuteNonQuery();
                    MessageBox.Show("修改数据成功！");

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

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}