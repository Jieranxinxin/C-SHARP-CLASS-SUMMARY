using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    //这个里面主要是初始化
    class Course
    {
        private string[] arrstr;

        //定义course这个类的构造函数
        public Course(int courseNum)
        {
            arrstr = new string[courseNum];
        }

        //定义索引
        //index下标,索引相当于类里面的属性，即可以输入，也可以拿出
        public string this[int index]
        {
            get
            {
                return arrstr[index];
            }
            set
            {
                arrstr[index] = value;
            }
        }

    }
}
