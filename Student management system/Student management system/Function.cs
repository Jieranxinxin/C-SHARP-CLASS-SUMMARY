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
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
        }

        private void dataShow(string stuIdParam, string stuNameParam)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle colStyle = new DataGridViewCellStyle();
            colStyle.BackColor = Color.AliceBlue;
            colStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = colStyle;

            dataGridView1.Columns[0].Name = "学号";
            dataGridView1.Columns[1].Name = "姓名";
            dataGridView1.Columns[2].Name = "选课";

            dataGridView1.Columns[0].Width = dataGridView1.Width / 3;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 3;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 3;

            string stuId = "";
            string stuName = "";
            string stuCourse = "";
            try
            {
                string connectionStr = "Data Source=.;Initial Catalog=TEST;Integrated Security=True";
                string fromStr = "SELECT USER_ID,USER_NAME,USER_COURSE FROM STUDENTMANAGEMENT WHERE 1=1";
                if (stuIdParam != string.Empty)
                {
                    fromStr += "AND USER_ID='" + txtID.Text + "'";
                }
                if (stuNameParam != string.Empty)
                {
                    fromStr += "AND USER_NAME='" + txtName.Text + "'";
                }
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = fromStr;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        stuId = Convert.ToString(reader[0]);
                        stuName = Convert.ToString(reader[1]);
                        stuCourse = Convert.ToString(reader[2]);
                        string[] row = new string[] { stuId, stuName, stuCourse };
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Function_Load(object sender, EventArgs e)
        {
            dataShow(string.Empty, string.Empty);
        }
        private void inquire_Click(object sender, EventArgs e)
        {
            dataShow(txtID.Text, txtName.Text);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add insert = new Add();
            insert.Show();
            this.Hide();
        }

        private void del_Click(object sender, EventArgs e)
        {
            //取主键
            string stuId = dataGridView1.CurrentCell.Value.ToString();
            DialogResult dialog = MessageBox.Show("确定要删除这条数据嘛？", "信息提示", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string connectionStr = "Data Source=.;Initial Catalog=TEST;Integrated Security=True";
                string deleteStr = "DELETE FROM STUDENTMANAGEMENT WHERE USER_ID = '" + stuId + "'";

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

        private void revamp_Click(object sender, EventArgs e)
        {
            string stuId = dataGridView1.CurrentCell.Value.ToString();
            //弹出Update
            Revamp update = new Revamp(stuId);
            update.Show();
            this.Hide();
        }
    }
}
