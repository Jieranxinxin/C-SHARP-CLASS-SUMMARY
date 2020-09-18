using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    //只要有一个方法声明为抽象方法，这个类也必须被声明为抽象类
    //抽象类，不能实例化
    abstract class Item
    {
        //不加public默认是私有的
        public abstract void showModelInfo();
        //抽象方法相当于一个空壳,so,这个位置什么都不做
    }
}
