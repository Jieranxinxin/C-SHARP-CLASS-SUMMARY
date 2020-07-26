using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200419Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.SubItems.Clear();
            li.SubItems[0].Text = textBox1.Text;
            li.SubItems.Add(textBox2.Text);
            li.SubItems.Add(comboBox1.Text);
            li.SubItems.Add(textBox4.Text);
            li.SubItems.Add(textBox5.Text);
            li.SubItems.Add(textBox6.Text);
            listView1.Items.Add(li);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            //列的表头
            listView1.Columns.Add("商品编号：",listView1.Width/6,HorizontalAlignment.Left);
            listView1.Columns.Add("商品名称：", listView1.Width / 6, HorizontalAlignment.Left);
            listView1.Columns.Add("单位：", listView1.Width / 6, HorizontalAlignment.Left);
            listView1.Columns.Add("商品型号：", listView1.Width / 6, HorizontalAlignment.Left);
            listView1.Columns.Add("商品规格：", listView1.Width / 6, HorizontalAlignment.Left);
            listView1.Columns.Add("进货数量：", listView1.Width / 6, HorizontalAlignment.Left);
            //下拉列表默认显示第一个
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
