using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重载_静态方法_实例方法
{
    //1.静态方法是，直接点那个类名
    //2.实例方法是，点那个实例的名字

    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 6;
            Add add = new Add();
            int sum = add.NumberAdd(a, b);
            int sum1 = add.NumberAdd(a, b, c);

            Console.WriteLine("运算结果：" + sum);
            Console.WriteLine("运算结果：" + sum1);

            Console.ReadKey();
        }
    }
}
