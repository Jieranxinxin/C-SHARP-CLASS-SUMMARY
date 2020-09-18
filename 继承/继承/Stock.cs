using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    //子类
    class Stock:Item
    {
        private String stockId;
        private String stockDate;

        public String StockId
        {
            get
            {
                return stockId;
            }
            set
            {
                stockId = value;
            }
        }
        public String StockDate
        {
            get
            {
                return stockDate;
            }
            set
            {
                stockDate = value;
            }
        }

        //base关键字   起到了从派生类中调用基类方法
        public String getStockInfo()
        {
            String infoStr = base.getItemInfo();
            infoStr += "进货编号：" + stockId + "\n" + "进货日期：" + stockDate+"\n";
            return infoStr;
        }
    }
}
