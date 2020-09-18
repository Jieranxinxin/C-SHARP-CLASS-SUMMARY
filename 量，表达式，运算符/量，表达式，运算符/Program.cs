using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 量_表达式_运算符
{
    class Program
    {
        static void Main(string[] args)
        {            
            //符号常量一般用于从网上下载东西的，默认地址，相对地址
            /*const string excelPath = "filepath\\path\\excelpath";
            string path = excelPath;*/
            
            int a = 15;
            Console.WriteLine("15>>2:  " + Convert.ToString(a >> 2));//a>>2是str，a是int要强制转换

            //装箱，隐式类型的转换
            int i = 100;
            object obj = new object();
            obj = i;
            Console.WriteLine(obj);

            //拆箱，显示转换
            object obj1 = new object();
            obj1 = i;
            int b = Convert.ToInt32(obj1);
            Console.WriteLine(b);
            //取反
            int z = 15;
            Console.WriteLine(~z);

            Console.ReadKey();
        }
    }
}
