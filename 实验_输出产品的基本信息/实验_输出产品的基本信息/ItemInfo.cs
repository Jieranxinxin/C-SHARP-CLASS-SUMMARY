using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验_输出产品的基本信息
{
    class ItemInfo
    {
        //商品代码
        private String itemCode;
        //商品名称
        private String itemName;
        //商品型号
        private String itemType;
        //商品规格
        private String itemStandard;
        //商品总数
        private String itemSum;
        //商品库存
        private int itemQty;
        //商品价格
        private float itemPrice;

        public String ItemCode
        {
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
        public String ItemType
        {
            get
            {
                return itemType;
            }
            set
            {
                itemType = value;
            }
        }
        public String ItemSum
        {
            get
            {
                return itemSum;
            }
            set
            {
                itemSum = value;
            }
        }
        public int ItemQty
        {
            get
            {
                return itemQty;
            }
            set
            {
                itemQty = value;
            }
        }
        public float ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }
        
        public void getItemInfo()
        {
            String retStr =
                "商品代码：" + this.ItemCode + "\n" +
                "商品名称：" + this.ItemName + "\n" +
                "商品型号：" + this.ItemType + "\n" +
                "商品单位：" + this.ItemSum + "\n" +
                "商品库存：" + this.ItemQty + "\n" +
                "商品价格：" + this.ItemPrice + "\n";
            Console.WriteLine(retStr);
        }

    }
}
