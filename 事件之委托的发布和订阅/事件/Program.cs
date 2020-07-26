using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    //定义一个委托，就相当于订阅了一个所有方法的一个类型  连接就相当于绑定
    /*过程
     * 1.定义委托类型，并在发布者类中定义一个该类型的公有成员
     * 2.在订阅这类型中定义委托处理方法
     * 3.订阅者对象将其事件处理方法链接到发布者对象的委托成员（一个委托类型的引用上）上。
     * 4.发布者对象在特定的情况下“激发”委托操作，从而自动调用订阅者对象的委托处理方法
     * 
     */
    public delegate void RingEvent(int ringKind);
    class Program
    {
        static void Main(string[] args)
        {
            SchoolRing sr = new SchoolRing();
            Student stu = new Student();
            stu.SubscrbeToRing(sr);

            Console.WriteLine("请输入打铃参数（1.表示打上课铃，2表示打下课铃）：");
            int ringKing = Convert.ToInt32(Console.ReadLine());
            sr.Jow(ringKing);

            Console.ReadKey();


        }
    }
}
