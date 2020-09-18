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

namespace Student_management_system
{
    public partial class Revamp : Form
    {
        public Revamp(string stuIdParam)
        {
            InitializeComponent();

            //将主键设成灰色，禁止用户更改
            textBox1.Enabled = false;

            //连接数据库
            string connectionStr = "Data Source=(local);DataBase=TEST;Integrated Security=True";
            string revampStr = "SELECT USER_ID,USER_NAME,USER_COURSE FROM STUDENTMANAGEMENT WHERE USER_ID='"
                + stuIdParam + "'";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = revampStr;
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
            string stuCourse = textBox3.Text;

            string connectionStr = "Data Source=(local);DataBase=TEST;Integrated Security=True";
            string updateStr = "UPDATE STUDENTMANAGEMENT SET USER_NAME= '" + stuName + "'," +
                "USER_COURSE ='" + stuCourse +
                "'WHERE USER_ID='" + stuId + "'";
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
                Function function = new Function();
                function.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Function function = new Function();
            function.Show();
            this.Hide();

        }
        
    }
}

