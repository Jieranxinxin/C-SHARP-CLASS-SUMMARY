using System;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] a = new int[10];
            //循环输入
            for (int i=0;i<=a.Length-1;i++)
            {
                Console.Write("Please enter NO:"+System.Convert.ToString(i+1)+"num:   ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //排序

            for (int i=0;i<=a.Length-1;i++)
            {
                for (int j=0; j <= a.Length - 2 - i; j++) {
                    if (a[j]>a[j+1])
                    {
                        int max = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = max;
                    }
                }
            }
            Console.WriteLine("排序后的内容： ");
            foreach (var e in a)
            {
                Console.Write(e+"\n");
            }
            */
            int[] a = new int[10];
            //循环输入
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write("Please enter NO:" + System.Convert.ToString(i + 1) + "num:   ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("排序后的内容:");
            Array.Sort(a);
            foreach (var e in a)
            {
                Console.Write(e + "\n");
            }
            Array.Reverse(a);
            Console.WriteLine("排序后反转的内容:");
            foreach (var e in a)
            {
                Console.Write(e + "\n");
            }
            Console.ReadKey();

        }
    }
}
