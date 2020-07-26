using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文件复制
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("点击成功", "信息提示", MessageBoxButtons.OK);
            if (dialogResult==DialogResult.OK)
            {
                MessageBox.Show("点击ok");
            }
            else
            {
                MessageBox.Show("点击取消");
            }
        }
    }
}
