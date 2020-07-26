using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        //未改时结果
        //这是一个销售模型。
        //这是一个进货模型。

        //由抽象类改成密封类后
        //且Item是基类，Sale继承Item,Stoke继承Sale
        //密封类的关键字是 sealed

        static void Main(string[] args)
        {
            Sale sale = new Sale();
            sale.showModelInfo();

            Stoke stoke = new Stoke();
            stoke.showModelInfo();

            Console.ReadKey();
        }
    }
}
