using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名
{
    class Program
    {
        //委托之后才可以匿名
        public delegate int DelCompute(int x, int y);
        public delegate string GetDelInfo();
        static void Main(string[] args)
        {
            Compute compute = new Compute();
            //定义委托DelCompute delCompute，再去绑定= compute.Add
            DelCompute delCompute = compute.Add;
            int sum = delCompute(2, 3);
            Console.WriteLine(sum);
            
            //这是一个语句块，所以要加分号
            DelCompute delAdd = delegate (int x, int y)
              {
                  return x + y;
              };
            //对于匿名来讲，用Invoke来执行语句块里的操作
            int sum2 = delAdd.Invoke(1, 2);
            Console.WriteLine(sum2);


            //第二个例子
            Validation val = new Validation();
            string infoStr = val.gerInfo();
            Console.WriteLine(infoStr);

            GetDelInfo getDelInfo = val.gerInfo;
            string delInfo = getDelInfo();
            Console.WriteLine(delInfo);

            GetDelInfo anonymous = delegate ()
            {
                string retStr = "匿名方法调用。";
                return retStr;
            };
            string anonymousStr = anonymous.Invoke();
            Console.WriteLine(anonymousStr);


            Console.ReadKey();
        }
    }
}
