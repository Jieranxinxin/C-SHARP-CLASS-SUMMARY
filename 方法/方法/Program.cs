using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    //1.ref,out都是引用传递，传递后改变传递的值会影响原来的值
    class Program
    {

        //1.值参数
        private static int Add(int x, int y)
        {
            x = x + y;
            return x;
        }

        //2.ref参数
        private static int Add(ref int m,int n)
        {
            m = m + n;
            return m;
        }

        //3.Out参数
        private static int Add(int x,int y,out int z)
        {
            z = x + y;
            return z;
        }

        //4.params   不定数目的参数,不知道参数的数量上
        //加上params不仅可以处理
        //int[] a={0,1,2}
        //Min(a)
        //还可以处理这个，没有不能处理
        //Min(1,2,3)
        private static int Add(int[] numParamArr)
        {
            int sum = 0;
            for (int i = 0; i < numParamArr.Length; i++)
            {
                sum += numParamArr[i];
            }
            return sum;

        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine("运算结果：" + Add(a, b));
            //值参数的时候a还是a=3
            Console.WriteLine("参数a的值：" + a);

            int c = 3;
            int d = 5;
            Console.WriteLine("运算结果：" + Add(ref c, d));
            //ref传参的时候，值变为Add之后的那个和  8
            Console.WriteLine("参数a的值：" + c);

            int e = 4;
            int f = 2;
            Console.WriteLine("运算结果：" + Add(e, f,out int z));
            Console.WriteLine("参数z的值：" + z);

            int[] numArr = { 1, 2, 3, 4, 5 };
            int sum = Add(numArr);
            Console.WriteLine("运算结果：" + sum);
            


            Console.ReadKey();

        }
    }
}
