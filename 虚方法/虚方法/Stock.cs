using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚方法
{
    //进货类
    class Stock:Item
    {
        //加new告诉系统，我在重写
        //new public void showModelInfo()
        //虚函数一个用法override，在这个里面重写
        public override void showModelInfo()
        {
            Console.WriteLine("这是一个进货模型。");
        }
    }
}
