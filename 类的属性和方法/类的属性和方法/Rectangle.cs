using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的属性和方法
{
    //继承Shape这个类
    class Rectangle:Shape
    {
        public int getArea()
        {
            return getWidth() * getHeight();
        }
    }
}
