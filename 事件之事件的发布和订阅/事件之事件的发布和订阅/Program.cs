using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件之事件的发布和订阅
{
    class Program
    {
        public delegate void RingEvent(int ringKind);

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
