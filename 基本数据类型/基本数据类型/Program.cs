using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //值传递
            Student stu1 = new Student();//类的实例化
            stu1.setAge(20);
            stu1.setName("可新");
            Student stu2 = new Student();
            stu2.setName("二哈");
            stu2.setAge(21);
            //引用传递
            Student stu3 = new Student();
            stu3 = stu2;
            stu2.setName("云");

            int testAge = stu1.getAge();
            stu1.setAge(19);

            Console.WriteLine("testAge: " + testAge);
            Console.WriteLine("after update: " + stu1.getAge());

            //引用传递,指向同一个内存地址
            Console.WriteLine("testStu3:"+stu3.getName());
            Console.WriteLine("testStu2:"+ stu2.getName());

            Console.ReadKey();
 
        }
        public class Student//定义学生类
        {
            public Student()
            {
            }             
            //一个完整的。。。要有一个和类名一样的构造函数 
            //里面什么都不写
            //定义两个属性
            //private私有的，别人看不到
            private String name;
            private int age;
            //public共有的，外面的人可以看到
            public int getAge()
            {
                return age;
            }
            public void setAge(int age)//修改，从外面改的那个值
            {
                //this指代的Student这个类
                this.age = age;
            }
            public String getName()
            {
                return name;
            }
            public void setName(String name)
            {
                this.name = name;
            }
        }
    }
}
