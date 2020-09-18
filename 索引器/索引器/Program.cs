using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    //C#支持一种名为索引器的特殊“属性”，它能够通过引用的数组元素的
    //方式来引用对象
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course(3);
            //set
            course[0] = "C#";
            course[1] = "java";
            course[2] = "11";

            //get
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(course[i]);
            }
            Console.ReadKey();
        }
    }
}
