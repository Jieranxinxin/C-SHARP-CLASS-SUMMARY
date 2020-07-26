

/*   在控制台上报错或警告
#undef warningInfo
#define errorInfo
*/

/*  
#define test//生效，想要失效#undef，用其定义的符号与具有相同名称的变量不冲突
#undef test2//主要定义符号，当将符号用作传递给#if指令的表达式时，其为true
#undef ConsoleVersion
#undef FramaworkVersion
#define ASPVersion
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 预处理指令
{
    class Program
    {
        
        //显示大纲的功能，指定可展开区域
        static void Main(string[] args)
        {
            /*     if  elif  else的使用
           #if (ConsoleVersion)
                       Console.WriteLine("这是一个控制台版本");
           #elif(FramaworkVersion)
                       Console.WriteLine("这是一个FramaworkVersion版本");
           #else
                       Console.WriteLine("这是一个ASP版本");

           #endif
           */

/*
#if (warningInfo)
#warning "生成警告信息！"
#elif (errorInfo)
#error "生成错误信息！"
#endif
*/

#region 登录逻辑判断
            Console.WriteLine("Please your userId:");
            string userId = Console.ReadLine();
            Console.WriteLine("Please your password:");
            string password = Console.ReadLine();
            if (userId.Equals("admin") && password.Equals("admin"))
            {
                Console.WriteLine("登录成功！");
            }
            else
            {
                Console.WriteLine("登录失败！");
            }
#endregion

            Console.ReadKey();
        }
    }
}
