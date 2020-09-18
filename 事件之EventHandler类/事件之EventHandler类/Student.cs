using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件之EventHandler类
{
    class Student
    {
        public void SchoolJow(object sender,EventArgs e)
        {
            //将e强制转换，先看e有没有RingKind属性，没有的话，强转RingEventArgs
            //(RingEventArgs)e强转
            //再加括号把((RingEventArgs)e)看成一个整体
            if (((RingEventArgs)e).RingKind == 2)
            {
                Console.WriteLine("同学们开始课间休息！");
            }
            else if (((RingEventArgs)e).RingKind == 1)
            {
                Console.WriteLine("童鞋们开始上课！");
            }
        }
        public void SubscrbeToRing(SchoolRing schoolRing)
        {
            schoolRing.onBellSound += SchoolJow;
        }
        public void CancelSubscrbe(SchoolRing schoolRing)
        {
            schoolRing.onBellSound -= SchoolJow;
        }
    }
}
