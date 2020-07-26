using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Home : UserControl
    {
        Random ran = new Random();
        public UC_Home()
        {
            InitializeComponent();
        }

        private void LoadChar()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);

            dataPoint.addLabely("Jan",ran.Next(0,50).ToString());
            dataPoint.addLabely("Feb", ran.Next(0, 50).ToString());
            dataPoint.addLabely("Mar", ran.Next(0, 50).ToString());
            dataPoint.addLabely("Apr", ran.Next(0, 50).ToString());
            dataPoint.addLabely("Jun", ran.Next(0, 50).ToString());
            dataPoint.addLabely("Aug", ran.Next(0, 50).ToString());
            dataPoint.addLabely("Sep", ran.Next(0, 50).ToString());
            dataPoint.addLabely("Oct", ran.Next(0, 50).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadChar();
        }

       
    }
}
