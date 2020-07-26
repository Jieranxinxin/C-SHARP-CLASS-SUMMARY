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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stuId = textBox1.Text;
            string stuName = textBox2.Text;
            string stuCourse = textBox3.Text;

            if (stuId == string.Empty || stuName == string.Empty || stuCourse == string.Empty)
            {
                MessageBox.Show("输入内容不能为空！");
                return;
                //写了return可以接着往下写，否则下面的逻辑写到if()\else()
            }
            // "Data Source=.;Initial Catalog=Test;Integrated Security=True"
            string connectionStr = "Data Source=.;Initial Catalog=TEST;Integrated Security=True";
            string insertStr = "INSERT INTO STUDENTMANAGEMENT VALUES("
           + "'" + stuId + "',"
           + "'" + stuName + "',"
           + "'" + stuCourse + "')";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = insertStr;
                    connection.Open();
                    //执行非查询语句
                    command.ExecuteNonQuery();
                    MessageBox.Show("新增数据成功！");

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
