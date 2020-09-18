using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的属性和方法
{
    class student
    {
        //私有的，外面看不见，相当于封装
        private String name;
        private int age;

        //公共的，外面可以看见，相当于方法
        public void SetName(String name)
        {
            this.name = name;//让变量等于形式参数
        }

        public String getName( )
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }

        public String getInfo()
        {
            return name + " " + age;
        }
    }
}
