using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{//用委托代替方法，因为他两个指向了同一块内存地址
    class Program
    {
        //委托的关键字delegate
        public delegate int DelCompute(int a, int b);
        static void Main(string[] args)
        {
            Compute compute = new Compute();
            DelCompute delCompute = compute.Add;
            int sum = delCompute(2, 3);
            Console.WriteLine(sum);

            GreetPeople("hanmeimei", "English");
            GreetPeople("韩梅梅","Chinese");

            /*委托式
             * DelGreeting delegate1=ChineseGreeting;
             * delegate1+=EnglishGreeting;
             * +=这个样子，他的地址即等于ChineseGreeting又等于EnglishGreeting;
             */


            Console.ReadKey();

        }

        public static void GreetPeople(string name,string languge)
        {
            //字符串判断用  Equals
            if (languge.Equals("English"))
            {
                EnglishGreeting(name);
            }else if (languge.Equals("Chinese"))
            {
                ChineseGreeting(name);
            }
        }
        //委托式写法
        /*public delegate int DelGreeting(string name,string languge);
         * 
         * public static void GreetPeople(string name,DelGreeeting Makegreeting)
         * {
         * MakeGreeeting(name);
         * }
         * 
         */



            //委托的类型要一样   在这里是void
            public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning"+name);
        }
        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好" + name);
        }
    }
}
