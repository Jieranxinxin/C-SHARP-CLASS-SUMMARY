using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    //父类
    class Item
    {
        private String itemCode;
        private String itemName;

        public String ItemCode {
            get
            {
                return itemCode;
            }
            set
            {
                itemCode = value;
            }
        }
        public String ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }
        public String getItemInfo()
        {
            String infoStr = "商品代码：" + itemCode + "\n" + "商品名称：" + itemName + "\n";
            return infoStr;
        }

    }
}
