using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Form2 : Form
    {
        private string stuId;
        private string stuName;
        private string stuClass;
        private string stuMajor;
        public Form2(string stuId, string stuName, string stuClass, string stuMajor)
        {
            InitializeComponent();
            this.stuId = stuId;
            this.stuName = stuName;
            this.stuClass = stuClass;
            this.stuMajor = stuMajor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("row0", stuId, 0);
            listView1.Items["row0"].SubItems.Add(stuName);
            listView1.Items["row0"].SubItems.Add(stuClass);
            listView1.Items["row0"].SubItems.Add(stuMajor);
        }
    }
}
