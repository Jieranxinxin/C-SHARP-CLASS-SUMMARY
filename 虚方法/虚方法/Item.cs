using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚方法
{
    //父类
    class Item
    {
        // public void showModelInfo()改成虚函数
        public virtual void showModelInfo()
        {
            Console.WriteLine("这是一个商品模型。");
        }
    }
}
