using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 frm1 = new Form1();
            //frm1.ShowDialog();
            //if (frm1.DialogResult == DialogResult.OK)
            //{
            //    frm1.Dispose();
            //    Application.Run(new Form2());
            //}
            //if (frm1.DialogResult == DialogResult.Cancel)
            //{
            //    frm1.Dispose();
            //    return;
            //}
            Application.Run(new Form1());
            
        }
    }
}
