using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Transactions;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;
using System.IO;

namespace PlanRemind
{
    public partial class Frm_Main : Form
    {
        //定义成员变量
        String strImagesPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
        int top=0, left=0, hei=0, wid=0;
        bool bo = false, bolTop = false;
        int x = 0, y = 0;
        public OleDbConnection oleConn = new OleDbConnection(String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data source={0}", Application.StartupPath + "\\PlanRemind.mdb"));//创建数据库连接对象
        List<CalFlag> listSource = new List<CalFlag>
            {
                new CalFlag{ DataValue ="1", DisplayText = "是"},
                new  CalFlag{ DataValue ="0", DisplayText = "否"}
            };
        //构造方法
        public Frm_Main()
        {
            InitializeComponent();
        }
 

        //窗体加载事件
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            InitSkin(strImagesPath);//默认蓝色经典
            OleDbDataAdapter oleDa = new OleDbDataAdapter("Select IsAutoCheck,Days,IsTimeCue,TimeInterval from tb_CueSetting", oleConn);
            DataTable dt = new DataTable();
            oleDa.Fill(dt);
            StringBuilder sb = new StringBuilder(string.Empty);
            if (Convert.ToBoolean(dt.Rows[0][0]))
            {
                sb.Append("软件启动后将自动检测未来" + dt.Rows[0][1].ToString()+"天内要执行的计划，"+Environment.NewLine);
                pic_PlanSearch_Click(sender, e);//触发计划查询图片按钮的Click事件
            }
            if (Convert.ToBoolean(dt.Rows[0][2]))
            {
                timer1.Interval = Convert.ToInt32((double)dt.Rows[0][3] * 3600 * 1000); //设置触发频率
                timer1.Enabled = true;//启动计时器
                sb.Append("软件每隔" + dt.Rows[0][3].ToString() + "小时会自动提醒一次！");
            }
            else
            {
                timer1.Enabled = false;//禁用计时器
            }
            if (sb.ToString() != string.Empty)
            {
                MessageBox.Show(sb.ToString(),"启动提示");
            }
            RunAutoClosePC();//启动自动关机功能
        }

        //pic_Close图片的事件
        //关闭事件。
        private void pic_Close_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pic_Close_MouseEnter(object sender, EventArgs e)
        {
            pic_Close.Image = Image.FromFile(strImagesPath + @"\images\close1.png");
        }

        private void pic_Close_MouseLeave(object sender, EventArgs e)
        {
            pic_Close.Image = Image.FromFile(strImagesPath + @"\images\close.png");
        }


        //pic_Minimize图片的事件
        //最小化事件
        private void pic_Minimize_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
        private void pic_Minimize_MouseEnter(object sender, EventArgs e)
        {
            pic_Minimize.Image = Image.FromFile(strImagesPath + @"\images\min1.png");
        }

        private void pic_Minimize_MouseLeave(object sender, EventArgs e)
        {
            pic_Minimize.Image = Image.FromFile(strImagesPath + @"\images\min.png");
        }


        //窗口再次被激活时。
        private void FormCusSkin_Activated(object sender, System.EventArgs e)
        {
            if (bo)
            {
                this.Top = top;
                this.Left = left;
                this.Height = hei;
                this.Width = wid;
                bo = false;
            }
        }


        //上边框
        //上边框鼠标按下。
        private void panel_Top_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            this.bolTop = true;
        }
        //上边框鼠标移动。 
        private void panel_Top_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (bolTop)
            {
                this.Top += e.Y - y;
                this.Left += e.X - x;
            }
        }
        //上边框鼠标释放。
        private void panel_Top_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.bolTop = false;
        }
        

        //自定义方法，初始化皮肤
        private void InitSkin(string strPath)
        {
            this.panel_Top.BackgroundImage = Image.FromFile(strPath + @"\images\top.png");
            this.panel_Left.BackgroundImage = Image.FromFile(strPath + @"\images\left.png");
            this.panel_Right.BackgroundImage = Image.FromFile(strPath + @"\images\right.png");
            this.panel_Bottom.BackgroundImage = Image.FromFile(strPath + @"\images\bottom.png");
            this.pic_Minimize.Image = Image.FromFile(strPath + @"\images\min.png");
            this.pic_Close.Image = Image.FromFile(strPath + @"\images\close.png");
            //this.BackgroundImage = Image.FromFile(strImagesPath + @"\images\background.gif");
        }



        //查询
        private void pic_PlanSearch_Click(object sender, EventArgs e)
        {
            //“查询”面板可见，其它面板不可见
            panel_PlanRegister.Visible = false;
            panel_PlanStat.Visible = false;
            panel_CueSetting.Visible = false;
            panel_HisSearch.Visible = false;
            panel_PlanSearch.Visible = true;
            //DataGridView控件中的列绑定数据
            DoFlag1.ConvertValueToText("DataValue", "DisplayText", listSource);
            chb_Days.Checked = true;//默认选择按照提前日期进行查询
            txt_PlanContent.Text = string.Empty;//清空标题文本框
            OleDbDataAdapter oleDa = new OleDbDataAdapter("Select Days from tb_CueSetting", oleConn);//创建OleDbDataAdapter实例
            DataTable dt = new DataTable();//创建DataTable实例
            oleDa.Fill(dt);//把数据填充到DataTable实例
            txt_QueryDays.Text = Convert.ToString(dt.Rows[0][0]);//显示系统设置的默认提前天数
            button6_Click(sender, e);//执行“查询”按钮的Click事件代码
        }
        private void dgv_BirSearch_MouseEnter(object sender, EventArgs e)
        {
            if (dgv_PlanSearch.Rows.Count > 0)
            {
                this.toolTip1.SetToolTip(dgv_PlanSearch, "双击记录执行计划");
            }
        }
        //控制天数只能为数字
        private void txt_QueryDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //计划统计
        private void pic_PlanStat_Click(object sender, EventArgs e)
        {
            panel_PlanRegister.Visible = false;
            panel_CueSetting.Visible = false;
            panel_PlanSearch.Visible = false;
            panel_HisSearch.Visible = false;
            panel_PlanStat.Visible = true;
            DoFlag2.ConvertValueToText("DataValue", "DisplayText", listSource);
        }
        //查询活未计划的数据
        private void button5_Click(object sender, EventArgs e)
        {
            string strSql = string.Empty;//定义存储SQL语句的字符串变量
            if (rb_DoFlag.Checked)//若选择计划
            {
                strSql = " SELECT * FROM tb_Plan where DoFlag = '1'";
            }
            else//若选择未计划
            {
                strSql = " SELECT * FROM tb_Plan where DoFlag = '0'";
            }
            oleDa = new OleDbDataAdapter(strSql, oleConn);//创建OleDbDataAdapter实例
            DataTable dt = new DataTable();//创建DataTable实例
            oleDa.Fill(dt);//把数据添加到DataTable实例中
            dgv_PlanStat.DataSource = dt;//DataGridView控件绑定数据源
            dgv_PlanStat.AlternateColor(Color.LightYellow);//在DataGridView控件中隔行换色显示记录
        }


        //历史查询
        private void pic_HisSearch_Click(object sender, EventArgs e)
        {
            panel_PlanRegister.Visible = false;
            panel_CueSetting.Visible = false;
            panel_PlanSearch.Visible = false;
            panel_PlanStat.Visible = false;
            panel_HisSearch.Visible = true;
            cbx_Year.Items.Clear();
            for (int i = 1; i <=10; i++)
            {
                cbx_Year.Items.Add(DateTime.Today.Year-i);
            }
            cbx_Year.SelectedIndex = 0;
            DoFlag3.ConvertValueToText("DataValue", "DisplayText", listSource);//扩展方法
        }
        //查询指定年份的计划情况
        private void btn_HisSearch_Click(object sender, EventArgs e)
        {
            string strSql = " SELECT * FROM tb_Plan  ";//定义SQL语句字符串变量
            strSql += " where year(ExecuteTime) = " + Convert.ToInt32(cbx_Year.Text) + " and PlanContent like '%" + txt_HisPlanContent.Text.Trim() + "%'";//设置SQL语句的过滤条件
            oleDa = new OleDbDataAdapter(strSql, oleConn);//创建OleDbDataAdapter实例
            DataTable dt = new DataTable();//创建DataTable实例
            oleDa.Fill(dt);//把数据填充到DataTable实例中
            dgv_HisSearch.DataSource = dt;//DataGridView控件绑定数据
            dgv_HisSearch.AlternateColor(Color.LightYellow);//在DataGridView控件中隔行换色显示数据
        }





        //登记
        OleDbDataAdapter oleDa = null;//声明OleDbDataAdapter类型的引用
        private void pic_PlanRegister_Click(object sender, EventArgs e)
        {
            //“计划录入”面板可见，其它面板不可见
            panel_CueSetting.Visible = false;
            panel_PlanStat.Visible = false;
            panel_PlanSearch.Visible = false;
            panel_HisSearch.Visible = false;
            panel_PlanRegister.Visible = true;
           
            //创建OleDbDataAdapter的实例
            oleDa = new OleDbDataAdapter("Select  * from tb_Plan", oleConn);
            DataTable dt = new DataTable();
            oleDa.Fill(dt);
            dgv_PlanRegister.DataSource = dt;//DataGridView控件绑定数据源
            dgv_PlanRegister.AlternateColor(Color.LightYellow);//DataGridView控件实现隔行换色显示数据
        }
        //单击某个单元格，则单元格所在的行处于可编辑状态。
        bool blIsEdit = false;
        private void dgv_BriRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            blIsEdit = true;
            ActivationControl(true);
            txt_PlanTitle.Text = Convert.ToString(dgv_PlanRegister.CurrentRow.Cells["PlanTitle"].Value);
            cbox_PlanKind.Text = Convert.ToString(dgv_PlanRegister.CurrentRow.Cells["PlanKind"].Value);
            dtp_ExecuteTime.Value = Convert.ToDateTime(dgv_PlanRegister.CurrentRow.Cells["ExecuteTime"].Value);
            rtb_PlanContent.Text = Convert.ToString(dgv_PlanRegister.CurrentRow.Cells["PlanContent"].Value);
        }
        //登记的“添加”按钮
        private void button2_Click(object sender, EventArgs e)
        {
            blIsEdit = false;//表示当前操作为添加状态
            ActivationControl(true);//激活当前界面上的控件

            RestUI();//重置界面控件
        }

        private void RestUI()
        {
            txt_PlanTitle.Text = "";//清空标题输入框
            cbox_PlanKind.Text = "一般计划";//初始化计划种类
            dtp_ExecuteTime.Value = DateTime.Today;
            rtb_PlanContent.Text = "";//清空内容
        }

        //自定义方法，用于激活控件
        private void ActivationControl(bool blValue)
        {
            txt_PlanTitle.Enabled = blValue;
            cbox_PlanKind.Enabled = blValue;
            dtp_ExecuteTime.Enabled = blValue;
            rtb_PlanContent.Enabled = blValue;
        }
        //保存
        private void button3_Click(object sender, EventArgs e)
        {
            string strSql = String.Empty;//定义存储SQL语句的字符串
            DataRow dr = null;//定义数据行对象
            DataTable dt = dgv_PlanRegister.DataSource as DataTable;//获取数据源
            oleDa.FillSchema(dt, SchemaType.Mapped);//配置指定的数据架构
            string strCue = string.Empty;//定义提示字符串
            if (txt_PlanTitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("标题不许为空！");//提示标题不许为空
                txt_PlanTitle.Focus();
                return;
            }
            if (blIsEdit)//若是修改操作状态
            {
                dr = dt.Rows.Find(dgv_PlanRegister.CurrentRow.Cells["IndivNum"].Value);//查找要修改的行
                strCue = "修改";
            }
            else//若是添加操作状态
            {
                dr = dt.NewRow();//创建新行
                dt.Rows.Add(dr);//在数据源中添加新创建的行
                strCue = "添加";
                dr["DoFlag"] = "0";
            }
            //给数据源的各个字段赋值
            dr["PlanTitle"] = txt_PlanTitle.Text.Trim();
            dr["PlanKind"] = cbox_PlanKind.Text;
            dr["ExecuteTime"] = dtp_ExecuteTime.Value;
            dr["PlanContent"] = rtb_PlanContent.Text;
            OleDbCommandBuilder scb = new OleDbCommandBuilder(oleDa);//关联数据库表单命令
            if (oleDa.Update(dt) > 0)//更新数据
            {
                MessageBox.Show(strCue + "成功！");
            }
            else
            {
                MessageBox.Show(strCue + "失败！");
            }
            //重重界面
            RestUI();
            ActivationControl(false);//禁用界面，等待下一次操作
            //清空UI
            //有助于更新IndivNum列
            dt.Clear();
            oleDa.Fill(dt);
            //以助于更新IndivNum列
        }
        //删除记录
         private void button4_Click(object sender, EventArgs e)
         {
             if (dgv_PlanRegister.CurrentRow != null)//若当前行不为空
             {
                 //若确定要删除
                 if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                 {
                     DataTable dt = dgv_PlanRegister.DataSource as DataTable;//获取数据源
                     oleDa.FillSchema(dt, SchemaType.Mapped);//配置指定的数据架构
                     int intIndivNum = Convert.ToInt32(dgv_PlanRegister.CurrentRow.Cells["IndivNum"].Value);//获取人员唯一编号
                     DataRow dr = dt.Rows.Find(intIndivNum);//查找指定数据行
                     dr.Delete();//删除数据行
                     OleDbCommandBuilder scb = new OleDbCommandBuilder(oleDa);//关联数据库表单命令
                     try
                     {
                         if (oleDa.Update(dt) > 0)//提交数据
                         {
                             if (oleConn.State != ConnectionState.Open)//弱连接为打开
                             {
                                 oleConn.Open();//打开连接
                             }
                             MessageBox.Show("删除成功！");
                         }
                         else//若删除失败
                         {
                             MessageBox.Show("删除失败！");
                         }
                     }
                     catch (Exception ex)//处理异常
                     {
                         MessageBox.Show(ex.Message, "软件提示");
                     }
                     finally//finally语句
                     {
                         if (oleConn.State == ConnectionState.Open)//若连接打开
                         {
                             oleConn.Close();//关闭连接
                         }
                     }
                 }
             }
         }






        //提示设置
        private void pic_CueSetting_Click(object sender, EventArgs e)
        {
            panel_PlanRegister.Visible = false;//计划录入面板不可见
            panel_PlanSearch.Visible = false;//计划查询面板不可见
            panel_PlanStat.Visible = false;//计划统计面板不可见
            panel_HisSearch.Visible = false;//历史查询面板不可见
            panel_CueSetting.Visible = true;//提醒设置面板不可见
            OleDbDataAdapter oleDa = new OleDbDataAdapter("Select top 1 * from tb_CueSetting",oleConn);//检索提醒设置数据表
            DataTable dt = new DataTable();//创建DataTable实例
            oleDa.Fill(dt);//把数据填充到DataTable实例
            if (dt.Rows.Count > 0)//若存在数据
            {
               DataRow dr = dt.Rows[0];//获取第一样数据
               nud_Days.Value=Convert.ToDecimal(dr["Days"]);//获取提前天数
               chb_IsAutoCheck.Checked = Convert.ToBoolean(dr["IsAutoCheck"]);//设置是否自动检查
               chb_IsTimeCue.Checked = Convert.ToBoolean(dr["IsTimeCue"]);//设置是否实时提醒
               nud_TimeInterval.Value = Convert.ToDecimal(dr["TimeInterval"]);//读取时间间隔
            }
        }
        //保存提示设置
        private void button1_Click(object sender, EventArgs e)
        {  
            OleDbCommand oleCmd = new OleDbCommand("SELECT top 1 * FROM tb_CueSetting", oleConn);//创建命令对象
            if (oleConn.State != ConnectionState.Open)//若数据连接未打开
            {
                oleConn.Open();//打开数据连接
            }
            OleDbDataReader oleDr = oleCmd.ExecuteReader();//创建只读数据流
           //定义插入SQL语句
            string strInsertSql = "INSERT INTO tb_CueSetting VALUES(" + Convert.ToInt32(nud_Days.Value) + "," + chb_IsAutoCheck.Checked + "," + chb_IsTimeCue.Checked + "," + Convert.ToDouble(nud_TimeInterval.Value)+")";
            //定义更新SQL语句
            string strUpdateSql = "UPDATE tb_CueSetting set Days = " + Convert.ToInt32(nud_Days.Value) + ",IsAutoCheck = " + chb_IsAutoCheck.Checked + ",IsTimeCue = " + chb_IsTimeCue.Checked + ",TimeInterval = " + Convert.ToDouble(nud_TimeInterval.Value);
            //获取本次要执行的SQL语句
            string strSql = oleDr.HasRows ? strUpdateSql : strInsertSql;
            oleDr.Close();//关闭只读数据流
            oleCmd.CommandType = CommandType.Text;//设置命令类型
            oleCmd.CommandText = strSql;//设置SQL语句
            if (oleCmd.ExecuteNonQuery() > 0)//若执行SQL语句成功
            {
                MessageBox.Show("设置成功！");
                if (chb_IsTimeCue.Checked)
                {
                    timer1.Interval = Convert.ToInt32(nud_TimeInterval.Value * 3600 * 1000);//设置Timer控件的触发频率
                    timer1.Enabled = true;//启动计时器
                }
                else
                {
                    timer1.Enabled = false;//禁用计时器
                }

            }
            else
            {
                MessageBox.Show("设置失败！");
            }
            oleConn.Close();//关闭连接
        }



        


        
        //查询
        //选择按天数查询
        private void chb_Days_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Days.Checked)
            {
                txt_QueryDays.Enabled = true;
                chb_PlanContent.Checked = false;
            }
            else
            {
                txt_QueryDays.Enabled = false;
            }

        }
        //选择按照标题查询
        private void chb_PersonName_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_PlanContent.Checked)
            {
                txt_PlanContent.Enabled = true;
                chb_Days.Checked = false;
            }
            else
            {
                txt_PlanContent.Enabled = false;
            }
        }
        //取消输入
        private void button7_Click(object sender, EventArgs e)
        {
            txt_QueryDays.Text = String.Empty;
            txt_PlanContent.Text = string.Empty;
            
        }
        //“查询”按钮
        public void button6_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(" Select * from tb_Plan Where ");//加载SQL语句创建StringBuilder实例
            if (chb_Days.Checked)//若选择按提前天数查询
            {
                if (String.IsNullOrEmpty(txt_QueryDays.Text.Trim()))//若天数为空
                {
                    MessageBox.Show("天数不许为空！","软件提示");//提示天数不许为空
                    return;
                }
                string strSql = "(format(ExecuteTime,'yyyy-mm-dd') >= '" + DateTime.Today.ToString("yyyy-MM-dd") + "' and format(ExecuteTime,'yyyy-mm-dd') <= '" + DateTime.Today.AddDays(Convert.ToInt32(txt_QueryDays.Text)).ToString("yyyy-MM-dd") + "')";//过滤提前天数符合查询条件的数据
                sb.Append(strSql);//连接查询字符串
            }
            else//若是按照人员标题查询
            {
                string strContentSql = " PlanContent like '%" + txt_PlanContent.Text.Trim() + "%'";//过滤符合查询条件的计划内容
                sb.Append(strContentSql);//连接查询字符串
            }
            oleDa = new OleDbDataAdapter(sb.ToString(), oleConn);//创建OleDbDataAdapter实例
            DataTable dt = new DataTable();//创建DataTable实例
            oleDa.Fill(dt);//把数据填充到DataTable实例中
            dgv_PlanSearch.DataSource = dt;//DataGridView控件绑定数据源
            dgv_PlanSearch.AlternateColor(Color.LightYellow);//隔行换色显示数据记录
        }
        //打开计划窗体
        private void dgv_BirSearch_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_PlanSearch.CurrentRow != null)
            {
                Frm_DoPlan fdp = new Frm_DoPlan();
                fdp.Owner = this;
                fdp.ShowDialog();
            }
        }
        //DataGridView控件的提示
        private void dgv_BirSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolTip1.SetToolTip(dgv_PlanSearch, "双击记录执行计划");
        }
       


        //鼠标单击托盘图标
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Show();
                pic_PlanSearch_Click(sender, e);
            }
        }
        




        //timer1控件定时提示即将过的信息
        private void timer1_Tick(object sender, EventArgs e)
        {
            //创建一个新的子线程，用于检索和提示数据，以减轻主线程的压力
            Thread th = new Thread(
                () =>
                {
                    Invoke(
                        (MethodInvoker)(() =>  //在当前窗体的线程上执行指定的委托。
                           {
                                int intDays;//存储提前天数
                                OleDbDataAdapter oleDa = new OleDbDataAdapter("Select Days from tb_CueSetting", oleConn);//创建OleDbDataAdapter实例，读取提前天数
                                DataTable dt = new DataTable();//创建DataTable实例
                                oleDa.Fill(dt);//把数据写入DataTable实例中
                                intDays = Convert.ToInt32(dt.Rows[0][0]);//获取提前天数
                                //读取将要过的人名
                                StringBuilder sb = new StringBuilder(" Select PlanTitle from tb_Plan Where ");//创建动态字符串
                                string strSql = " DoFlag = '0' and   (format(ExecuteTime,'yyyy-mm-dd') >= '" + DateTime.Today.ToString("yyyy-MM-dd") + "' and format(ExecuteTime,'yyyy-mm-dd') <= '" + DateTime.Today.AddDays(intDays).ToString("yyyy-MM-dd") + "')";//过滤日期符合查询条件的记录
                                sb.Append(strSql);//追加字符串
                                oleDa = new OleDbDataAdapter(sb.ToString(), oleConn);//得到新的OleDbDataAdapter实例
                                oleDa.Fill(dt);//把数据写入DataTable实例中
                                sb.Clear();//清空动态字符串
                                foreach (DataRow dr in dt.Rows)//遍历数据行
                                {
                                    sb.Append(dr["PlanTitle"].ToString() + Environment.NewLine);//追加字符串
                                }

                                if (!String.IsNullOrEmpty(sb.ToString().Trim()))//若存在过的人员
                                {
                                    string strTemp = string.Empty;
                                    if (intDays == 0)
                                    {
                                        strTemp = "今天有以下未执行的计划任务:";
                                    }
                                    else
                                    { 
                                        strTemp =  "未来" + intDays + "天内有以下未执行的计划任务:";
                                    }
                                    this.notifyIcon1.ShowBalloonTip(1000, "计划提示：",strTemp + sb.ToString() + "详细情况请单击托盘图标！", ToolTipIcon.Info);
                                }
                                else//若不存在过的人员
                                {
                                    string strTemp = string.Empty;
                                    if (intDays == 0)
                                    {
                                        strTemp = "今天无未执行的计划任务:";
                                    }
                                    else
                                    {
                                        strTemp = "未来" + intDays + "天内无未执行的计划任务:";
                                    }
                                    this.notifyIcon1.ShowBalloonTip(1000, "计划提示：", strTemp + "\n详细情况请单击托盘图标！", ToolTipIcon.Info);
                                }
                            }));
                });
            th.IsBackground = true;//设置新的子线程在后台执行
            th.Start();//启动新的子线程
        }


        //退出图片的Click事件
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }




        /*//其它鼠标的进入和离开事件的代码
        private void pic_PlanSearch_MouseEnter(object sender, EventArgs e)
        {
            pic_PlanSearch.Image = Image.FromFile(strImagesPath + @"\images\计划查询1.jpg");
        }

        private void pic_PlanSearch_MouseLeave(object sender, EventArgs e)
        {
            pic_PlanSearch.Image = Image.FromFile(strImagesPath + @"\images\计划查询.jpg");
        }

        private void pic_PlanStat_MouseEnter(object sender, EventArgs e)
        {
            pic_PlanStat.Image = Image.FromFile(strImagesPath + @"\images\计划统计1.jpg");
        }

        private void pic_PlanStat_MouseLeave(object sender, EventArgs e)
        {
            pic_PlanStat.Image = Image.FromFile(strImagesPath + @"\images\计划统计.jpg");
        }

        private void pic_HisSearch_MouseEnter(object sender, EventArgs e)
        {
            pic_HisSearch.Image = Image.FromFile(strImagesPath + @"\images\历史查询1.jpg");
        }

        private void pic_HisSearch_MouseLeave(object sender, EventArgs e)
        {
            pic_HisSearch.Image = Image.FromFile(strImagesPath + @"\images\历史查询.jpg");
        }

        private void pic_PlanRegister_MouseEnter(object sender, EventArgs e)
        {
            pic_PlanRegister.Image = Image.FromFile(strImagesPath + @"\images\计划录入1.jpg");
        }

        private void pic_PlanRegister_MouseLeave(object sender, EventArgs e)
        {
            pic_PlanRegister.Image = Image.FromFile(strImagesPath + @"\images\计划录入.jpg");
        }

        private void pic_CueSetting_MouseEnter(object sender, EventArgs e)
        {
            pic_CueSetting.Image = Image.FromFile(strImagesPath + @"\images\提醒设置1.jpg");
        }

        private void pic_CueSetting_MouseLeave(object sender, EventArgs e)
        {
            pic_CueSetting.Image = Image.FromFile(strImagesPath + @"\images\提醒设置.jpg");
        }

        private void pic_Exit_MouseEnter(object sender, EventArgs e)
        {
            pic_Exit.Image = Image.FromFile(strImagesPath + @"\images\退出1.jpg");
        }

        private void pic_Exit_MouseLeave(object sender, EventArgs e)
        {
            pic_Exit.Image = Image.FromFile(strImagesPath + @"\images\退出.jpg");
        }
*/


        //右键单击托盘图标，单击“打开”快捷菜单项
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            pic_PlanSearch_Click(sender, e);
        }
        //右键单击托盘图标，单击“退出”快捷菜单项
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private enum StartupFlag
        {
            StartupYes = 1,//自动运行应用程序
            StartupNo = 0//取消自动运行应用程序
        }

        private void 定时开关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ClosePC closePC = new Frm_ClosePC();
            closePC.Show();
        }
        //关于定时关机的功能
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll",ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();
        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);
        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);
        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
           ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int uFlags, int dwReserved);
        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        private bool DoExitWin(int flg)
        {
            bool ok;
            ok = ExitWindowsEx(flg, 0);
            return ok;
        }
        private void logout()//注销
        {
            ExitWindowsEx(EWX_LOGOFF, 0);
            Application.Exit();
        }

        private void Shutdown()//关机
        {
            DoExitWin(EWX_SHUTDOWN);
            Application.Exit();
        }

        private void BeginPC()//重启
        {
            DoExitWin(EWX_REBOOT);
            Application.Exit();
        }


        string settime;//保存定时时间
        int settype;//保存关机类型
        int autorun;//是否启用定时关机功能
        string message;//存储提示信息
        int cycle;//存储执行周期
        bool judge = true;//判断是否有ID为1的数据和是否启用自动关机功能

        private void refurbishInfo()
        {
            if (oleConn.State != ConnectionState.Open)//若数据连接未打开
            {
                oleConn.Open();//打开数据连接
            }
            OleDbCommand cmd = new OleDbCommand("select * from SetSystem where ID=1", oleConn);//创建命令对象
            OleDbDataReader dr = cmd.ExecuteReader();//得到只读数据流
            dr.Read();
            settime = Convert.ToDateTime(dr["SetTime"]).ToString("hh:mm:ss");//获取设置的关机时间
            settype = Convert.ToInt32(dr["SetType"]);//获取关机类型
            autorun = Convert.ToInt32(dr["IsAutoRun"]);//获取是否开机运行
            message = dr["Message"].ToString();//获取提示信息
            cycle = Convert.ToInt32(dr["cycle"]);//执行的周期
            dr.Close();//关闭只读数据流
            oleConn.Close();//关闭数据连接
        }

        private void ExecuteCommand()
        {
            refurbishInfo();
            string setTime = settime;//得到设置时间
            string nowTime = DateTime.Now.ToString("hh:mm:ss");//获取现在时间
            if (setTime.Equals(nowTime))
            {
                switch (settype)
                {
                    case 0: Shutdown(); break;//关机
                    case 1: BeginPC(); break;//重新启动机器
                    case 2: logout(); break;//注销
                    case 3: MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                }
            }
        }



        private void JudgeIDAndAutoRun()//判断是否有ID为1的数据和是否启用自动关机功能
        {
            if (oleConn.State != ConnectionState.Open)
            {
                oleConn.Open();
            }
            OleDbCommand cmd = new OleDbCommand("select IsAutoRun from SetSystem where ID=1", oleConn);

            Nullable<int> i = cmd.ExecuteScalar() as Nullable<int>;
            if (i != null)//存在初始化记录
            {
                if (i.Value == 0)//不启用自动关机功能
                {
                    judge = false;
                }
                else//启用自动关机功能
                {
                    judge = true;
                }
            }
            else//不存在初始化记录
            {
                judge = false;
            }
        }


        private void RunAutoClosePC()
        {

            JudgeIDAndAutoRun();//判断是否存在ID为1的数据
            if (judge)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }


            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            refurbishInfo();
            if (cycle == 0)
            {
                ExecuteCommand();
            }
            else
            {
                int nowWeek = DateTime.Now.DayOfWeek.GetHashCode();
                if (nowWeek == cycle)
                {
                    ExecuteCommand();
                }
            }
        }
    }
}
