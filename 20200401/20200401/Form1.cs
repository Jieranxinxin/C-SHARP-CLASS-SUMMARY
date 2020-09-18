using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "测试标签";
            textBox2.ReadOnly = true;
            textBox2.Text = "此处不允许输入";
            checkBox1.Font = new Font("微软雅黑",12f,FontStyle.Regular);
            checkBox2.Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            checkBox3.Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            checkBox4.Font = new Font("微软雅黑", 12f, FontStyle.Regular);

            checkBox1.Text = "中国";
            checkBox2.Text = "美国";
            checkBox3.Text = "法国";
            checkBox4.Text = "日本";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮被点击一次");
            //f1跳转f2
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮被点击一次");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string majorStr = "您选的国家是：";
            //遍历所有的控件，他们的基类是Control,用其建立一个对象,在划定一个范围
            foreach (Control ctrl in this.Controls) {

                //判断一下控件类型
                if (ctrl.GetType().Name=="CheckBox")
                {
                    //强转类型转换
                    CheckBox cBox = (CheckBox)ctrl;
                    //判断cBox是否别选中
                    if (cBox.Checked == true) {
                        //如果直接写等于，再来的字符串会将其覆盖，但+=会不断的拼接
                        majorStr += "\n"+cBox.Text;
                    }
                }
            }
            //再将其内容打出
            MessageBox.Show(majorStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string majorStr = "你选的国家是：";
            if (checkBox1.Checked)
            {
                majorStr += "\n" + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                majorStr += "\n" + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                majorStr += "\n" + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                majorStr += "\n" + checkBox4.Text;
            }
            MessageBox.Show(majorStr);
        }
    }
}
