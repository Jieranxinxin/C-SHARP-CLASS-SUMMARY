using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多窗体
{
    public partial class Form3 : Form
    {
        //这两个属性是全局的，私有的
        private string userId;
        private string userName;
        public Form3(string userIdParam,string uersNameParam)
        {
            InitializeComponent();
            userId = userIdParam;
            userName = uersNameParam;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("111");
            listBox1.Items.Add(userId);
            listBox1.Items.Add(userName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
