using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个_接口
{
    //接口可以继承多个，类不能继承多个
    class Compute:ICalculateTwoNumbers,ICalculateThreenumbers
    {
        int ICalculateTwoNumbers.Add()
        {
            int x = 1;
            int y = 2;
            return x + y;
        }
        int ICalculateThreenumbers.Add()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            return x + y + z;
        }
    }
}
