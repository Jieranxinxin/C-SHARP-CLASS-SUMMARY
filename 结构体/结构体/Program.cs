using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("1001", "zhang");
            emp.PrintInfo();
            Console.ReadKey();

        }
    }
}
