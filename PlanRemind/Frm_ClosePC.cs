using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using Microsoft.Win32;

namespace PlanRemind
{
    public partial class Frm_ClosePC : Form
    {
        public Frm_ClosePC()
        {
            InitializeComponent();
        }

      string strg;//数据库路径
      OleDbConnection conn;
      OleDbCommand cmd;
      OleDbDataReader sdr;

      bool judge = true;//判断是否存在ID为1的数据
      private void GetSetInfo()
      {
          string settime;
          int settype;//获取关机类型
          int autorun;//获取是否开机运行
          string message;//
          int cycle;//执行的周期
          JudgeID();//判断是否存在ID为1的数据
          if (judge)
          {
              conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);
              conn.Open();
              cmd = new OleDbCommand("select * from SetSystem where ID=1", conn);
              sdr = cmd.ExecuteReader();
              sdr.Read();
              settime = sdr["SetTime"].ToString();//获取设置的关机时间
              settype = Convert.ToInt32(sdr["SetType"]);//获取关机类型
              autorun = Convert.ToInt32(sdr["IsAutoRun"]);//获取是否开机运行
              message = sdr["Message"].ToString();//获取提示信息
              cycle = Convert.ToInt32(sdr["cycle"]);//执行的周期
              sdr.Close();
              conn.Close();
              dateTimePicker1.Text = settime;
              switch (settype)
              {
                  case 0: rbShutDown.Checked = true; break;
                  case 1: rbBegin.Checked = true; break;
                  case 2: rbLogout.Checked = true; break;
                  case 3: rbShowMessage.Checked = true;
                      txtMessage.Text = message;
                      break;
              }
              if (autorun == 0)
              {
                  chbAutoRun.Checked = false;
              }
              else
              {
                  chbAutoRun.Checked = true;
              }
              if (cycle == 0)//每天
              {
                  rbcycleDay.Checked = true;
                  cbbWeek.SelectedIndex = 0;
              }
              else//周几
              {
                  rbcycleWeek.Checked = true;
                  if (cycle >= 1 || cycle <= 7)
                  {
                      cbbWeek.SelectedIndex = cycle - 1;
                  }
              }
          }
          else
          {
              MessageBox.Show("请设置数据，初始化程序！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              cbbWeek.SelectedIndex = 0;
          }
      }

        private void AddCommand()
        {
            string settime1;//保存定时关机时间
            int settype1=0;//保存关机类型
            int autorun1 = 0;//保存是否启用定时关机
            string message1="请输入提示信息";
            int cycle1;//保存执行周期

            settime1 = dateTimePicker1.Text;//获取定时关机时间
            if (rbShutDown.Checked)//若选择关机
            {
                settype1 = 0;//设置类型参数值
            }
            if (rbBegin.Checked)//若选择重启
            {
                settype1 = 1;
            }
            if (rbLogout.Checked)//若选择注销
            {
                settype1 = 2;
            }
            if (rbShowMessage.Checked)//若选择显示信息
            {
                settype1 = 3;
            }

            if (chbAutoRun.Checked)//若选择启用重启功能
            {
                autorun1 = 1;//设置参数值为1
               
            }
            else//若选择不启用重启功能
            {
                autorun1 = 0;
               
            }

            if (rbShowMessage.Checked)//若选择显示信息
            {
                if (txtMessage.Text == "")//若输入的信息为空
                {
                    MessageBox.Show("输入提示信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);//弹出提示框
                }
                else
                {
                    message1 = txtMessage.Text.Trim();//获取输入的显示消息
                }
            }
            if (rbcycleDay.Checked)//若选择每天执行
            {
                cycle1 = 0;//设置参数值为0
            }
            else//若选择每周几执行
            {
                cycle1 = cbbWeek.SelectedIndex + 1;//设置参数值
            }
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);//创建数据库连接
            conn.Open();//打开数据库连接
            string strSQL="";//定义SQL语句字符串
            if(judge)//若修改定时关机信息
            {
                strSQL="update SetSystem set SetTime='" + settime1 + "',SetType='" + settype1 + "',IsAutoRun='" + autorun1 + "',Message='" + message1 + "',cycle='"+cycle1+"' where ID=1";//修改定时关机信息的SQL语句
            }
            else//若添加定时关机信息
            {
                strSQL = "insert into SetSystem(ID,SetTime,SetType,IsAutoRun,Message,cycle) values (1,'" + settime1 + "','" + settype1 + "','" + autorun1 + "','" + message1 + "','" + cycle1 + "')";//添加定时关机信息的SQL语句
            }
            cmd = new OleDbCommand(strSQL, conn);//创建命令对象
            int k = cmd.ExecuteNonQuery();//执行SQL语句
            if (k > 0)//若执行成功
            {
                if (MessageBox.Show("设置成功") == DialogResult.OK)
                {
                    conn.Close();//关闭连接
                    this.Close();//关闭当前窗体
                }
            }
        }

        private void JudgeID()
        {
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);//创建数据库连接
            conn.Open();//打开数据连接
            cmd = new OleDbCommand("select count(*) from SetSystem where ID=1", conn);//创建查询是否存在数据记录的命令对象
            int i = (int)cmd.ExecuteScalar();//执行包含聚合函数的SQL语句
            if (i == 0)//若无数据记录
            {
                judge = false;//judge变量值为false
            }
            else//若有数据记录
            {
                judge = true;//judge变量值为true
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNowTime.Text = DateTime.Now.Date.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
            strg = Application.StartupPath.ToString();
            strg += @"\PlanRemind.mdb";
            GetSetInfo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)//取消按钮
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//确定按钮
        {
            AddCommand();
        }
    }
}
