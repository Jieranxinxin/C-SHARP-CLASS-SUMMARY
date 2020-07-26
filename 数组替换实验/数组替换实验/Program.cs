using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组替换实验
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("请输入你想要的行和列：");
                Console.WriteLine("请输入行：");
                string rowstr = Console.ReadLine();
                Console.WriteLine("请输入列：");
                string colstr = Console.ReadLine();

                int row = Convert.ToInt32(rowstr);
                int col = Convert.ToInt32(colstr);


                int[,] numArr = new int[row, col];
                for (int i = 0; i < numArr.GetLength(0); i++)
                {
                    for (int j = 0; j < numArr.GetLength(1); j++)
                    {
                        numArr[i, j] = 1;
                        Console.Write(numArr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                

            while (true)
            {
                Console.WriteLine("小可爱，你是否想修改其中的数据。");
                Console.WriteLine("如果修改，请输入Y或y");
                Console.WriteLine("否则，请输入N或n");
                string in_number = Console.ReadLine();

                //判断循环条件是否成立

                if (in_number == "Y"|| in_number == "y")
                {
                    Console.WriteLine("请在需要修改的行，列中用空格隔开");
                    String inputStr = Console.ReadLine();
                    //Split（），去掉（）里面的，将其余的分开
                    String[] updStr = inputStr.Split(' ');
                    //一般使用一维数组接收

                    //int.Parse（）  能转换为整形的转换成整形，不能转换，抛出异常
                    row = int.Parse(updStr[0]) - 1;
                    col = int.Parse(updStr[1]) - 1;
                    numArr[row, col] = 0;


                    for(int i = 0; i < numArr.GetLength(0); i++)
                    {
                        for(int j = 0; j < numArr.GetLength(1); j++)
                        {
                            Console.Write(numArr[i,j]+" ");
                        }
                        Console.WriteLine();
                    }


                }else if (in_number=="N"||in_number=="n"){
                    break;
                }
                else
                {
                    Console.WriteLine("输入有误，请重新输入！");
                    continue;
                }
                   
            }
            Console.WriteLine("班级：软件技术19-01\n姓名：张可新\n学号：201902912210143");
            Console.ReadKey();
        }
    }
}
