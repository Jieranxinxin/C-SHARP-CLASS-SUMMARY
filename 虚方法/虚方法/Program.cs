using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.showModelInfo();
            //Item类不变，对象换成Sale()
            //但是对象并没有起作用，它是由Item这个类决定的
            //把它改成虚方法之后，就可以等到想要的样子
            //未改之前
            /*这是一个商品模型
             * 这是一个商品模型
             * 这是一个商品模型

 *              * 改之后
             * 这是一个商品模型
             * 这是一个进货模型
             * 这是一个销售模型

             */
            Item sale = new Sale();
            sale.showModelInfo();

            Item stoke = new Stock();
            stoke.showModelInfo();

            Console.ReadKey();
        }
    }
}
