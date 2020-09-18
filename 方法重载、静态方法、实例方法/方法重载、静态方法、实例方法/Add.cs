using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重载_静态方法_实例方法
{
    class Add
    {
        public int NumberAdd(int x,int y)
        {
            return x + y;
        }
        public int NumberAdd(int x,int y,int z)
        {
            return x + y + z;
        }
    }
}
