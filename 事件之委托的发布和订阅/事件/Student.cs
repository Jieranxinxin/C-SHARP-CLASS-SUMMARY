using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Student
    {
        public void SchoolJow(int ringKind)
        {
            if(ringKind==2)
            {
                Console.WriteLine("同学们开始课间休息！");
            }else if (ringKind == 1)
            {
                Console.WriteLine("童鞋们开始上课！");
            }        
        }
        public void SubscrbeToRing(SchoolRing schoolRing)
        {
            //直接=会覆盖结果
            schoolRing.onBellSound += SchoolJow;
        }
        public void CancelSubscrbe(SchoolRing schoolRing)
        {
            schoolRing.onBellSound -= SchoolJow;
        }
    }
}
