using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //一、
            string[] str = new string[]
            {
                "12345",
                "1234455",
                "1234567",
                "6789900000283"
            };

            //定义枚举的接口，接受值
            IEnumerable<string> selectQuery =
                from Name in str
                where Name.Length <= 7
                select Name;
            foreach (string testStr in selectQuery)
            {
                Console.WriteLine(testStr);
            }
            Console.WriteLine();

            //二、
            string[] strWords ={ "Aaa","BCC","ccc"};
            //var定义一个变量
            var ChangeWord =
                from word in strWords
                    //Upper相当于在里面定义了一个属性
                select new { Upper=word.ToUpper(), Lower=word.ToLower() };
            foreach (var VWord in ChangeWord)
            {
                Console.WriteLine("大写：{0},小写：{1}",VWord.Upper,VWord.Lower);
            }
            Console.WriteLine();

            //三、
            string[] strLists = new string[]
            {
                "aaabbb",
                "bbbccc",
                "cccddd"
            };
            string[] testStr1 = Array.FindAll(strLists,s=>(s.IndexOf("bbb")>=0));
            foreach (string str1 in testStr1)
            {
                Console.WriteLine(str1);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
