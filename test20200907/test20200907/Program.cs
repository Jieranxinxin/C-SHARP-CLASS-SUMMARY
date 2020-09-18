using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test20200907
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            Console.WriteLine("Pealse a namber:");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i=0;i<=a;i++)
            {
                sum += i;
            }
            Console.WriteLine("结果是："+sum);
            Console.ReadKey();
        }
        
    }
}
