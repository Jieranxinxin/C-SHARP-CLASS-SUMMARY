using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static 事件.Program;

namespace 事件
{
    class SchoolRing
    {

        //该类型的公有成员onBellSound
        public RingEvent onBellSound;
        public void Jow(int ringKing)
        {
            if (ringKing == 1 || ringKing == 2)
            {
                //判断发布者的反应
                if (ringKing == 1)
                {
                    Console.WriteLine("上课铃响了！");
                }
                else
                {
                    Console.WriteLine("下课铃响了！");
                }
                //判断订阅者的反应
                if (onBellSound != null)
                {
                    //回调函数，在这去调用委托的对象
                    onBellSound(ringKing);
                }
                else
                {
                    Console.WriteLine("这个铃声的参数不正确！");
                }
            }
        }
    }
}
