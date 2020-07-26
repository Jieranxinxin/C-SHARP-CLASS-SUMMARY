using System;
using System.Collections.Generic;
using System.IO;//命名空间
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200429
{
    class Program
    {
        static void Main(string[] args)
        {
            //@在带转义字符的字符串前面可以消除转移字符的作用
            // 加在字符串前面，字符串中的 " 要用 "" 表示
            //用关键字做变量时在关键字前面加@
            string path = @"D:\Learning\TestFile\1.txt";



            //FileInfo非静态类  对其实例化
            //FileInfo fi=new FileInfo(path)
            //fi.Exists
            //fi.CopyTo(path1);


            //写
            if (!File.Exists(path))
            {
                using (StreamWriter sw=File.CreateText(path))
                {
                    sw.WriteLine("HelloWorld!");
                    sw.WriteLine("Welcome!");
                }
            }
            //读
            //using限定一个范围，在范围结束时处理对象
            using (StreamReader sr=File.OpenText(path))
            {
                string test = "";
                while ((test = sr.ReadLine() )!= null)
                {
                    Console.WriteLine(test);
                }
            }

            //复制
            string path1 = @"D:\Learning\TestFile\2.txt";
            if (File.Exists(path1))
            {
                File.Delete(path1);
            }
            //Copy(原路径，目标路径)
            File.Copy(path,path1);
            Console.WriteLine("{0}复制到{1}",path,path1);

            Console.ReadKey();
        }
    }
}
