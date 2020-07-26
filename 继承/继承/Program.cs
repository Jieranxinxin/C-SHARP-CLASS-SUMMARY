using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            stock.StockId = "1001";
            stock.StockDate = "20200304";
            stock.ItemCode = "0001";
            stock.ItemName = "笔记本电脑";

            Console.WriteLine("商品代码：" + stock.ItemCode);
            Console.WriteLine("商品名称："+stock.ItemName);
            Console.WriteLine("进货编号："+stock.StockId);
            Console.WriteLine("进货日期："+stock.StockDate);

            Console.ReadKey();

        }
    }
}
