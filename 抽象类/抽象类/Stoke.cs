using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    //将Stoke 密封
    //class Stoke :Sale
    class Stoke:Item
    {
        //密封之后，没有重写的理由了
        public override void showModelInfo()
        

        {
            Console.WriteLine("这是一个进货模型。");
        }
    }
}
