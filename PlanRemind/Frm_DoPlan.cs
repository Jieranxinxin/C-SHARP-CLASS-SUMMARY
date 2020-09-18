using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PlanRemind
{
    public partial class Frm_DoPlan : Form
    {


        public Frm_DoPlan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strDoFlag = String.Empty;//定义描述计划执行的标记
            if (chb_DoFlag.CheckState == CheckState.Checked)//若标记该计划已经按期执行
            {
                strDoFlag = "1";//设置计划执行标记为1
            }
            else
            {
                strDoFlag = "0";//设置计划执行标记为0
            }

            string strSql = "Update tb_Plan set DoFlag = '" + strDoFlag + "',Explain='" + rtb_Explain.Text + "' where IndivNum = " + intIndivNum;//修改处理信息
           
            OleDbCommand oleCmd = new OleDbCommand(strSql,oleConn);//创建命令对象

            if (oleConn.State != ConnectionState.Open)//若连接未打开
            {
                oleConn.Open();//打开连接
            } 
            if (oleCmd.ExecuteNonQuery() > 0)//执行SQL语句
            {
                MessageBox.Show("完成！","软件提示");//提示完成
                Frm_Main frm = (Frm_Main)this.Owner;
                //frm.chb_Days.Checked = false;
                frm.button6_Click(sender, e);
            }
            else
            {
                MessageBox.Show("失败！","软件提示");//提示还未完成
            }
            oleConn.Close();//关闭连接
            this.Close();//关闭当前窗体
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int intIndivNum;//人员的唯一编号
        OleDbConnection oleConn = null;
        private void Frm_GivingGrant_Load(object sender, EventArgs e)
        {
            //获取窗体上主要的数值，从主窗口窗体过来
            Frm_Main frm_Main = (Frm_Main)this.Owner;
            intIndivNum = Convert.ToInt32(frm_Main.dgv_PlanSearch.CurrentRow.Cells["IndivNum1"].Value);
            //判断该人员是否发放过礼物
            oleConn = frm_Main.oleConn;
            OleDbCommand oleCmd = new OleDbCommand("SELECT PlanTitle,DoFlag,Explain FROM tb_Plan where IndivNum = " + intIndivNum, oleConn);
            if (oleConn.State != ConnectionState.Open)
            {
                oleConn.Open();//打开连接
            }
            OleDbDataReader oleDr = oleCmd.ExecuteReader();
            oleDr.Read();
            if (oleDr.HasRows)
            {
                txt_PlanTitle.Text = Convert.ToString(oleDr["PlanTitle"]);
                chb_DoFlag.CheckState = Convert.ToString(oleDr["DoFlag"]) == "1" ? CheckState.Checked : CheckState.Unchecked;
                rtb_Explain.Text = Convert.ToString(oleDr["Explain"]);
            }
            oleConn.Close();//关闭连接
        }

    }
}
