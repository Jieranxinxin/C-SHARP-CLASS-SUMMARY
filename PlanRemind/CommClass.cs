using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
namespace PlanRemind
{
    class CalFlag
    {
        public string DisplayText//存储DisplayMember属性值
        {
            get;
            set;
        }
        public string DataValue//存储ValueMember属性值
        {
            get;
            set;
        }
    }

    static class ExtendDataGridView								//数据绑定和设置DataGridView控件的隔行换色
    {
        /// <summary>
        /// 转换DataGridViewComboBoxColumn列的数据值为显示值
        /// </summary>
        /// <param name="dgvcbxColumn">DataGridViewComboBoxColumn列</param>
        /// <param name="strValueMemberName">数据值</param>
        /// <param name="strDisplayMemberName">显示值</param>
        /// <param name="items">集合</param>
        public static void ConvertValueToText(this DataGridViewComboBoxColumn dgvcbxColumn, string strValueMemberName, string strDisplayMemberName, ICollection items) 			//声明一个扩展方法
        {
            dgvcbxColumn.DataSource = items;//设置数据源
            dgvcbxColumn.ValueMember = strValueMemberName;//设置数据值
            dgvcbxColumn.DisplayMember = strDisplayMemberName;//设置显示值
        }
        /// <summary>
        /// 在DataGridView控件中隔行换色显示数据记录
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="color">偶数行的颜色</param>
        public static void AlternateColor(this DataGridView dgv, Color color)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//设置选定模式为整行
            foreach (DataGridViewRow dgvr in dgv.Rows)//遍历所有的数据行
            {
                if (dgvr.Index % 2 == 0)//若是偶数行
                {
                    dgvr.DefaultCellStyle.BackColor = color;//设置偶数行的背景颜色
                }
            }
        }
    }

    class LunarClass
    {
        /// <summary>
        /// 农历数据
        /// </summary>
        private static int[] LunarData =    {2635,333387,1701,1748,267701,694,2391,133423,1175,396438
            ,3402,3749,331177,1453,694,201326,2350,465197,3221,3402
            ,400202,2901,1386,267611,605,2349,137515,2709,464533,1738
            ,2901,330421,1242,2651,199255,1323,529706,3733,1706,398762
            ,2741,1206,267438,2647,1318,204070,3477,461653,1386,2413
            ,330077,1197,2637,268877,3365,531109,2900,2922,398042,2395
            ,1179,267415,2635,661067,1701,1748,398772,2742,2391,330031
            ,1175,1611,200010,3749,527717,1452,2742,332397,2350,3222
            ,268949,3402,3493,133973,1386,464219,605,2349,334123,2709
            ,2890,267946,2773,592565,1210,2651,395863,1323,2707,265877};
        //农历日期
        private static string[] DayName =   {"*","初一","初二","初三","初四","初五",
             "初六","初七","初八","初九","初十",
             "十一","十二","十三","十四","十五",
             "十六","十七","十八","十九","二十",
             "廿一","廿二","廿三","廿四","廿五",      
             "廿六","廿七","廿八","廿九","三十"};

        //农历月份
        private static string[] MonthName = { "*", "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "腊" };

        //公历月计数天
        private static int[] MonthAdd = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        /// <summary>
        /// 获取对应日期的农历及其他信息
        /// </summary>
        /// <param name="dtDay">公历日期</param>
        /// <returns>农历信息</returns>
        public static DateTime GetLunarCalendar(DateTime dtDay)
        {
            string sYear = dtDay.Year.ToString();//获得年份
            string sMonth = dtDay.Month.ToString();//获取月份
            string sDay = dtDay.Day.ToString();//获取日期
            int year;//存储年份
            int month;//存储月份
            int day;//存储日期
            try
            {
                year = int.Parse(sYear);//字符串年份转换为整型年份
                month = int.Parse(sMonth);//字符串月份转换为整型月份
                day = int.Parse(sDay);//字符串日期转换为整型日期
            }
            catch
            {
                year = DateTime.Now.Year;
                month = DateTime.Now.Month;
                day = DateTime.Now.Day;
            }
            int nTheDate;
            int nIsEnd;
            int k, m, n, nBit, i;
            string calendar = string.Empty;
            //计算到初始时间1921年2月8日的天数：1921-2-8(正月初一)
            nTheDate = (year - 1921) * 365 + (year - 1921) / 4 + day + MonthAdd[month - 1] - 38;
            if ((year % 4 == 0) && (month > 2))
                nTheDate += 1;
            //计算天干，地支，月，日
            nIsEnd = 0;
            m = 0;
            k = 0;
            n = 0;
            while (nIsEnd != 1)//判断是否结束
            {
                if (LunarData[m] < 4095)//若未到达年末
                    k = 11;
                else//若到达年终
                    k = 12;
                n = k;
                while (n >= 0)//若本年份还未结束
                {
                    //获取LunarData[m]的第n个二进制位的值
                    nBit = LunarData[m];
                    for (i = 1; i < n + 1; i++)
                        nBit = nBit / 2;
                    nBit = nBit % 2;
                    if (nTheDate <= (29 + nBit))//判断指定日期是否未到月末
                    {
                        nIsEnd = 1;
                        break;
                    }
                    nTheDate = nTheDate - 29 - nBit;
                    n = n - 1;
                }
                if (nIsEnd == 1)//若月份结束
                    break;
                m = m + 1;
            }
            year = 1921 + m;//得到年份
            month = k - n + 1;//得到月份
            day = nTheDate;//得到日期
            //返回农历日期
            return Convert.ToDateTime(String.Format(@"{0}/{1}/{2}",year,month,day));
        }
    }


}
