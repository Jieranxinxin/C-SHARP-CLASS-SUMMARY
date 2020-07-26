using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的属性和方法
{
    class Shape
    {
        private int width;
        private int height;

        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int getWidth()
        {
            return width;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int getHeight()
        {
            return height;
        }
    }
}
