using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("     ****************************     \n     *      图书馆管理系统      *     ");
            
            Console.Write("     * 请输入班级：");
            
            String a=Console.ReadLine();//Console.Read无法将int转换成string
            //Console.Write("*");
            Console.WriteLine("     *      班 级: " + (String)a);
            Console.Write("     *     请输入姓名  ： ");
            String b = Console.ReadLine();
            Console.WriteLine("     *      姓 名 ：      " + (string)b);
            Console.WriteLine("     ****************************     ");
            Console.ReadLine();
            

        }
    }
}
