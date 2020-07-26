using BookShopManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timer2.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home uC_Home = new UC_Home();
            AddControlIsToPanel(uC_Home);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width>=PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }

            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width<=72)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlIsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(button1);
            UC_Home uC_Home = new UC_Home();
            AddControlIsToPanel(uC_Home);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(button2);
            UC_sales uC_Sales = new UC_sales();
            AddControlIsToPanel(uC_Sales);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveSidePanel(button4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveSidePanel(button3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moveSidePanel(button5);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Time.Text = dt.ToString("HH.MM.SS");
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
