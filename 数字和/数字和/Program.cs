using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数字和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            Console.ReadKey();
        }
    }
}
