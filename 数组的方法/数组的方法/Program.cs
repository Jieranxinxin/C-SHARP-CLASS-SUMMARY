using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //原数组
            int[] numSourceArr = new int[5];
            //目标数组
            int[] numTargetArr = new int[10];//数组长度要长一点，以防数组越界

            //对原数组初始化
            Console.WriteLine("原数组：");
            for(int i = 0; i < numSourceArr.Length; i++)
            {
                numSourceArr[i] = i;
                Console.Write(numSourceArr[i]+" ");
            }

            Console.WriteLine();

            //对目标数组初始化
            Console.WriteLine("目标数组：");
            for (int i = 0; i < numTargetArr.Length; i++)
            {
                numTargetArr[i] = i + 3;
                Console.Write(numTargetArr[i] + " ");
            }
            Console.WriteLine();

            /*1.Copy
             * 
            Array.Copy(numSourceArr,2, numTargetArr,1,3);
            //执行复制以后的目标数组
            Console.WriteLine("复制后的目标数组：");
            for (int i = 0; i < numTargetArr.Length; i++)
            {
                Console.Write(numTargetArr[i] + " ");
            }
              */


            /*2.CopyTo
            numSourceArr.CopyTo(numTargetArr, 2);

            Console.WriteLine("复制后的目标数组：");
            for (int i = 0; i < numTargetArr.Length; i++)
            {
                Console.Write(numTargetArr[i] + " ");
            }
            */


            /*
             * 3.Exists  判断某个数组里面是否有某元素，返回值是布尔
            bool flag = Array.Exists(numSourceArr, element => element == 5);
            Console.WriteLine(flag);
            //IndexOf(数组名，元素)，存在返回其下标，不存在返回-1
            int flagint = Array.IndexOf(numSourceArr, 3);
            Console.WriteLine(flagint);
            */


            //GetValue（想要得到值的下标） and Set Value(想要换的数，被换数的下标)
            Console.WriteLine(numTargetArr.GetValue(3));
            numTargetArr.SetValue(10, 4);
            for (int i = 0; i < numTargetArr.Length; i++)
            {
                Console.Write(numTargetArr[i] + " ");
            }



            /*Reverse 作用，倒序
            Array.Reverse(numSourceArr);
            for (int i = 0; i < numSourceArr.Length; i++)
            {
                Console.Write(numSourceArr[i] + " ");
            }
            */

            Console.WriteLine();
            //Sort  排序 默认：从小到大
            Array.Sort(numTargetArr);
            for (int i = 0; i < numTargetArr.Length; i++)
            {
                Console.Write(numTargetArr[i] + " ");
            }


            Console.WriteLine();
            String[] numStr = { "11", "12", "13" };
            foreach(String str in numStr)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
