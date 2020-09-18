using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 选择语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please you scores：");
            int score = Convert.ToInt32(Console.ReadLine());
            switch (score/10)
            {
                case 10:
                    Console.WriteLine("你真么这么棒!");
                    break;
                case 9:
                case 8:
                case 7:
                case 6:
                    Console.WriteLine("不错哦！");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("OH NO 没有及格偶，要加油！");
                    break;
            
            }
            Console.ReadKey();
        }
    }
}
