using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组_跳转语句
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //goto 可以跳转到label处，一般不要用，太灵活

            int sum = 0;
            for(int i = 1; i < 5; i++)
            {
                if (i == 3)
                {
                    goto label;
                }
                sum = sum + i;
                
            }

            label://此处是冒号  ：
            Console.WriteLine(sum);
            */



            //以下数组
            //一维数组的定义
            int[] testArr;//定义一个数组
            testArr = new int[10] {1,2,3,4,5,6,7,8,9,10};//初始化

            //二维数组
            int[,] testArr2;
            testArr2 = new int[3,2];//定义一个三行两列的数组
            //二维数组的遍历
            for(int i = 0; i < testArr2.GetLength(0); i++)//GetLength(0)一维数组的长度
            {                                            //放的是0，求得一维的长度

                for(int j = 0; j < 2; j++)
                {
                    testArr2[i, j] = 0;
                    //Console.WriteLine("*");
                    Console.Write(testArr2[i,j]);
                }
                Console.WriteLine();
            }


            //不规则数组
            //*
            //**
            //***
            //****
            //*****
            int[][] testArr3;
            testArr3 = new int[5][];
            Console.ReadKey();
        }
    }
}
