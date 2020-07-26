using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    
    class Sale:Item
    
    {
        //override 重写的声明
        //抽象类中这样写   
        public override void showModelInfo()

        //密封类中这样写public sealed override void showModelInfo()
        {
            Console.WriteLine("这是一个销售模型。");
        }
    }
}
