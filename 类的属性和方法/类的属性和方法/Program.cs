using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的属性和方法
{
    class Program
    {
        //对象的静态部分对应类的属性
        //对象的动态部分对应类的方法
        static void Main(string[] args)
        {
            student stu1 = new student();//实例化对象

            stu1.SetName("新新");
            stu1.SetAge(12);
            Console.WriteLine(stu1.getInfo());



            Rectangle rect = new Rectangle();
            //子类有父类的信息，父类不一定有子类的信息
            rect.SetHeight(30);
            rect.SetWidth(20);
            Console.WriteLine("长方形的面积为：");
            Console.WriteLine(rect.getArea());

            //实例化
            Car car = new Car();
            Pickup pickup = new Pickup();
            String carinfo = car.basicFunction();
            String pickupinfo = pickup.basicFunction();

            Console.WriteLine(carinfo);
            Console.WriteLine(pickupinfo);
            
            
            
            
            
            Console.ReadKey();


        }
    }
}
