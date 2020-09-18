using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验_输出产品的基本信息
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemInfo itemInfo = new ItemInfo();
            itemInfo.ItemCode = "0001";
            itemInfo.ItemName = "ipad";
            itemInfo.ItemType = "Ty90";
            itemInfo.ItemSum = "台";
            itemInfo.ItemQty = 1000;
            itemInfo.ItemPrice = 1222.3f;
            itemInfo.getItemInfo();

            Console.ReadKey();
        }
    }
}
