using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        //隐藏全部panelSubmenu
        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelEqualizerSubmanu.Visible = false;
            panelPlaylistSubMune.Visible = false;
            //..
        }

        //隐藏单个panelSubmenu
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible==true)
            {
                panelMediaSubmenu.Visible = false;
            }
            if (panelEqualizerSubmanu.Visible==true)
            {
                panelEqualizerSubmanu.Visible = false;
            }
            if (panelPlaylistSubMune.Visible==true)
            {
                panelPlaylistSubMune.Visible = false;
            }
        }

        //显示panelSubmenu
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void butMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            //Your codes 
            //..
            hideSubMenu();
        }

        private void butPlayLIst_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
            showSubmenu(panelPlaylistSubMune);
        }

        #region  EqualizerSubmanu
        private void butEqualizer_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEqualizerSubmanu);
        }
        #endregion

        #region   在panel里面创建窗体
        private Form activeFrom = null;
        private void openChildForm(Form childForm){
            if (activeFrom!=null)
                activeFrom.Close();
            activeFrom = childForm;
            activeFrom.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
