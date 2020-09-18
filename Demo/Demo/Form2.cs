using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int course = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (!cb_updata.Checked)
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = false;
                    if (item is Button)
                        item.Enabled = false;
                }
            string sql = "select stu_number as '学号',stu_name as '姓名',stu_sex as '性别',stu_age as '年龄',stu_class as '班级',stu_native_place as '籍贯' from TB_Students";
            dataGridView1.DataSource = DBHelper.Select(sql);
        }

        private void cb_updata_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_updata.Checked)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = false;
                    if (item is CheckBox)
                        item.Enabled = false;
                    if (item is Button)
                        item.Enabled = false;
                }
            }
            else
            {
                foreach (Control item0 in groupBox1.Controls)
                {
                    if (item0 is TextBox)
                        item0.Enabled = true;
                    if (item0 is CheckBox)
                        item0.Enabled = true;
                    if (item0 is Button)
                        item0.Enabled = true;
                }
            }
            txt_num.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Course.Clear();
            int num = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    txt_name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txt_sex.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    txt_age.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    txt_class.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    txt_place.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    txt_num.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
            }
            string sql = "select s.stu_name,c.c_name from TB_Student_Course as sc left join TB_Students as s on s.stu_number=sc.stu_number "
                       + "left join TB_Course as c on c.c_id=sc.c_id where s.stu_number='" + num + "'";

            if (DBHelper.Select(sql).Rows.Count == 0)
            {
                txt_info.Text = "该同学没有选课记录！";
                return;
            }


            txt_info.Text = DBHelper.Select(sql).Rows[0]["stu_name"].ToString() + " 同学选择的科目：";
            for (int i = 0; i < DBHelper.Select(sql).Rows.Count; i++)
                txt_Course.AppendText(DBHelper.Select(sql).Rows[i]["c_name"].ToString() + ";");
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                sql = "delete from TB_Student_Course where stu_number='" + txt_age.Text.Trim() + "'";
                DBHelper.OperationSQL(sql);
                sql = "update TB_Students set stu_name='" + txt_name.Text.Trim() + "',stu_age='" + txt_age.Text.Trim() + "',stu_class='" + txt_class.Text.Trim() + "',stu_native_place='" + txt_place.Text.Trim()
                    + "',stu_sex='" + txt_sex.Text.Trim() + "' where stu_number='" + txt_num.Text.Trim() + "'";
                DBHelper.OperationSQL(sql);

                sql = "select stu_number as '学号',stu_name as '姓名',stu_sex as '性别',stu_age as '年龄',stu_class as '班级',stu_native_place as '籍贯' from TB_Students";
                dataGridView1.DataSource = DBHelper.Select(sql);

                sql = "insert into TB_Student_Course values('" + txt_num.Text.Trim() + "','" + course + "')";
                DBHelper.OperationSQL(sql);

                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = false;
                    if (item is CheckBox)
                        item.Enabled = false;
                    if (item is Button)
                        item.Enabled = false;
                }
                cb_updata.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton cb = (RadioButton)sender;
            switch (cb.Name)
            {
                case "radioButton1":
                    course = 1;
                    break;
                case "radioButton2":
                    course = 2;
                    break;
                case "radioButton3":
                    course = 3;
                    break;
                case "radioButton4":
                    course = 4;
                    break;
                case "radioButton5":
                    course = 5;
                    break;
                default:
                    break;
            }
        }


    }
}
