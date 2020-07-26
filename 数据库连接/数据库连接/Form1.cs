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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataShow(string.Empty,string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataShow(textBox1.Text,textBox2.Text);
        }

        private void dataShow(string stuIdParam,string stuNameParam)
        {
            //专门显示数据的一个控件
            dataGridView1.Rows.Clear();
            //ColumnCount代表列的个数
            dataGridView1.ColumnCount = 3;
            //表头可见的
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle();
            columnStyle.BackColor = Color.AliceBlue;
            columnStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnStyle;

            dataGridView1.Columns[0].Name = "学号";
            dataGridView1.Columns[1].Name = "姓名";
            dataGridView1.Columns[2].Name = "性别";

            dataGridView1.Columns[0].Width = dataGridView1.Width / 3;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 3;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 3;

            //连接字符串分为三个部分，第一个部分本地数据库服务器，第二个数据库的名字，第三个登陆方式
            //“local”或“.”代表本地     数据库名字不区分大小写
            //可以Initial Catalog也可以database
            //
            string stuID = "";
            string stuSAX = "";
            string stuName = "";
            try
            {
                string connectionStr = "Data Source=.;Initial Catalog=Test;Integrated Security=True";
                //From 后加一个表名
                //string formStr = "SELECT USERS1_ID,USERS1_NAME,USERS1_SAX FROM USERS1 ";
                //这样写出错的风险小
                string formStr = "SELECT USERS1_ID,USERS1_NAME,USERS1_SAX FROM USERS1 WHERE 1=1 ";

                if (stuIdParam!=string.Empty)
                {
                    //formStr+= "WHERE USERS1_ID='" + textBox1.Text + "'";
                    formStr += "AND USERS1_ID='" + textBox1.Text + "'";
                }
                if (stuNameParam!=string.Empty)
                {
                    formStr+= "AND USERS1_NAME='" + textBox2.Text + "'";
                }
                    

                /*执行的时候需要三个类
                SqlConnection
                SqlCommand
                SqlDataReader  把生成的那个东西放到这个集合里
                只要创建了连接就要释放
                */
                //自动把connection释放掉
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    //用这个连接去创建对象
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = formStr;
                    //一定要把连接打开
                    connection.Open();
                    //只查询
                    SqlDataReader reader = command.ExecuteReader();
                    //遍历出来
                    while (reader.Read())
                    {
                        //列
                        stuID = Convert.ToString(reader[0]);
                        stuName = Convert.ToString(reader[1]);
                        stuSAX = Convert.ToString(reader[2]);
                        string[] row = new string[] { stuID,stuName, stuSAX };
                        dataGridView1.Rows.Add(row);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //当前单元格的value值
            string stuId = dataGridView1.CurrentCell.Value.ToString();
            //弹出Update
            Update update = new Update(stuId);
            update.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //取主键
            string stuId = dataGridView1.CurrentCell.Value.ToString();
            DialogResult dialog = MessageBox.Show("确定要删除这条数据嘛？","信息提示",MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                string connectionStr = "Data Source=.;Initial Catalog=Test;Integrated Security=True";
                string deleteStr= "DELETE FROM USERS1 WHERE USERS1_ID = '"+stuId+"'";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionStr))
                    {
                        SqlCommand command = connection.CreateCommand();
                        command.CommandText = deleteStr;
                        connection.Open();
                        //执行非查询语句
                        command.ExecuteNonQuery();
                        MessageBox.Show("删除数据成功！");

                    }
                    dataShow(string.Empty, string.Empty);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        else
            {
                return;
            }


        }
    }
}
