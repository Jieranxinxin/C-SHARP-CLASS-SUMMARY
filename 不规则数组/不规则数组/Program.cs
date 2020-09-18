using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 不规则数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义不规则数组
            int[][] testArr;
            testArr = new int[5][];

            //数组的赋值
            testArr[0] = new int[1] { 1 };
            testArr[1] = new int[2] { 1,2 };
            testArr[2] = new int[3] { 1,2,3 };
            testArr[3] = new int[4] { 1,2,3,4 };
            testArr[4] = new int[5] { 1,2,3,4,5 };

            //遍历数组输出
            for(int i = 0; i < testArr.GetLength(0); i++)
            {
                for(int j=0; j < testArr[i].GetLength(0); j++)
                {
                    Console.Write(testArr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
