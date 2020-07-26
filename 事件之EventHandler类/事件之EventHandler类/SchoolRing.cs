using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 事件之EventHandler类;

namespace 事件之EventHandler类
{

    public class SchoolRing
    {
        public event EventHandler onBellSound;
        public void Jow(int ringKind)
        {
            if (ringKind == 1 || ringKind == 2)
            {
                if (ringKind == 1)
                {
                    Console.WriteLine("上课铃响了！");
                }
                else
                {
                    Console.WriteLine("下课铃响了！");
                }
                if (onBellSound != null)
                {
                    //this当前的这个事件
                    onBellSound(this, new RingEventArgs(ringKind));
                }
                else
                {
                    Console.WriteLine("这个铃声的参数不正确！");
                }
            }
        }
    }
}
