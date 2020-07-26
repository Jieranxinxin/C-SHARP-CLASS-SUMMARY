using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    public struct Employee
    {
        public String empId;
        public String empName;

        //声明构造函数，得带参数
        public Employee(String paramId,String paramName)
        {
            empId = paramId;
            empName = paramName;

        }
        public void PrintInfo()
        {
            Console.WriteLine(empId +"  "+ empName);
        } 

    }
}
