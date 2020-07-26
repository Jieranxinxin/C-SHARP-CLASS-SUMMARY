using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management_system
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //透明度，红绿蓝  0-255
            panel2.BackColor = Color.FromArgb(150,204,212,230);
        }


        Boolean textBoxHasTest = false;//判断输入框是否有文本
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (textBoxHasTest==false)
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Brown;
            }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                txtName.Text = "请输入用户名";
                txtName.ForeColor = Color.Silver;
                textBoxHasTest = false;
            }
            else
            {
                textBoxHasTest = true;
            }
        }
         


        Boolean txtPwdHasTest = false;//判断输入框是否有文本
        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwdHasTest == false)
            {
                txtPwd.Text = "";
                txtPwd.PasswordChar = (char)42;
                txtPwd.ForeColor = Color.Brown;
            }
        }
        private void txtPwd_Leave(object sender, EventArgs e)
        {
            if (txtPwd.Text == "")
            {
                txtPwd.Text = "请输入密码";
                txtPwd.ForeColor = Color.Silver;
                txtPwdHasTest = false;
                txtPwd.PasswordChar = '\0';
            }
            else
            {
                txtPwdHasTest = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text==string.Empty||txtPwd.Text==string.Empty)
            {
                MessageBox.Show("用户名和密码不可为空！","信息提示！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else if(txtName.Text=="user"&&txtPwd.Text=="111")
            {
                Function function = new Function();
                function.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！","信息提示！",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
