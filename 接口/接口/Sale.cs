using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    //销售类实现接口
    class Sale:Item
    {
        public void showModelInfo()
        {
            Console.WriteLine("这是一个销售模型。");
        }

    }
}
