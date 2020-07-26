using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 符号常量运算符表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //符号常量一般用于从网上下载东西的，默认地址，相对地址
            /*const string excelPath = "filepath\\path\\excelpath";
            string path = excelPath;*/
            int a=15;
            Console.Write("15>>2:" + Console.ToString(a >> 2));//a>>2是str，a是int要强制转换
            Console.ReadKey();

        }
    }
}
