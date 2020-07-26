using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //不可以直接赋值，因为两边类型不匹配，可以用构造函数
            radioButton1.Font = new Font("微软雅黑", 12.0f, FontStyle.Regular);
            radioButton2.Font = new Font("微软雅黑", 12.0f, FontStyle.Regular);
            radioButton3.Font = new Font("微软雅黑", 12.0f, FontStyle.Regular);

            radioButton1.Text = "vivo";
            radioButton2.Text = "oppo";
            radioButton3.Text = "华为";

            //Both的属性   水平进度条  Vertical纵向有滚动条，横向没有
            //Horizontal只要横向不要纵向
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            richTextBox1.WordWrap = false;

            //表达字体的两种方式  并且，后写的会把上一个覆盖
            //richTextBox1.Font = new Font("微软雅黑",20.0f,FontStyle.Italic);
            richTextBox1.SelectionFont = new Font("微软雅黑",40.0f,FontStyle.Underline);
            richTextBox1.SelectionColor = System.Drawing.Color.AliceBlue;

            //设置超链接
            richTextBox1.Text = "https://mooc1-1.chaoxing.com/mycourse/studentstudy?chapterId=293711797&courseId=206030605&clazzid=12051999&enc=2e0ab7e37d193eb3242b9fdb6d313094";

            //像是HTML中的无序列表
            richTextBox1.SelectionBullet = true;
            //缩进
            richTextBox1.SelectionIndent = 100;

            /*
             * 为下拉列表赋值   
             * 方法1.直接点黑色右三角  编辑项   进行
             * 方法2.下面例子
             * 方法3.连上数据库
             * string[] comboStr=new string[]{
             * 
             * "",
             * "",
             * 
             * };
             * conboBox1.DataSource=comboStr;
             * 
             */
            comboBox1.SelectedIndex = 0;

            listBox1.Items.Add("西瓜111111111111");
            listBox1.Items.Add( "苹果");
            listBox1.Items.Add("猕猴桃");
            listBox1.Items.Add("菠萝");
            listBox1.Items.Add("圣女果");
            listBox1.Items.Add("水蜜桃");



            //移除
            listBox1.Items.Remove("菠萝");

            listBox1.ScrollAlwaysVisible = true;
            listBox1.HorizontalScrollbar = true;
            //MultiExtended   用组合键   可以多选  shift可以连续多选   ctrl 不连续多选
            //MultiSimple  不用组合键来实现上面的多选
            listBox1.SelectionMode = SelectionMode.MultiSimple;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                MessageBox.Show("您选择的是：" + radioButton1.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("您选择的是：" + radioButton2.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MessageBox.Show("您选择的是：" + radioButton3.Text);
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //Diagnostics直接在浏览器中打开
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点一下，再移除   
            //listBox1.Items.Remove("水蜜桃");
            //删下标为3的数，会报异常，最好从0开始
           
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("不可删  Label里无值");
            }
            else if (listBox1.Items.Count>0){
                listBox1.Items.RemoveAt(0);
            }
        }
    }
}
