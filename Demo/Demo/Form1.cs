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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "select stu_number,stu_password from TB_Students where stu_number='" + txt_stu_number.Text.Trim() + "'and stu_password='" + txt_stu_password.Text.Trim() + "'";
            if (DBHelper.Select(sql).Rows.Count != 1)
            {
                MessageBox.Show("学号、密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
