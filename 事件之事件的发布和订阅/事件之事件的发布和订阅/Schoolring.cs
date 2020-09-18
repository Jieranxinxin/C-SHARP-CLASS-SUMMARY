using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static 事件之事件的发布和订阅.Program;

namespace 事件之事件的发布和订阅
{
    class SchoolRing
    {
        //事件与委托那就差一个event，保证事件订阅的可靠性
        public event RingEvent onBellSound;
        public void Jow(int ringKing)
        {
            if (ringKing == 1 || ringKing == 2)
            {
                if (ringKing == 1)
                {
                    Console.WriteLine("上课铃响了！");
                }
                else
                {
                    Console.WriteLine("下课铃响了！");
                }
                if (onBellSound != null)
                {
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
