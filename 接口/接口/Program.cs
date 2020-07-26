using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
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
