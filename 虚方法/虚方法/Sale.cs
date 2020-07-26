using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚方法
{
    class Sale:Item
    {
        //new public void showModelInfo()
        public override void showModelInfo()
        {
            Console.WriteLine("这是一个销售模型。");
        }
    }
}
