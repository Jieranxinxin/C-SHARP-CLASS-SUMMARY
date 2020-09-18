using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商品的基本信息
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*********销售明细*********");
                Sale[] saleJan = {new Sale("01","樱花勋章") ,new Sale("02","樱花丝巾"),new Sale("03","樱花季纪念书"),
                new Sale("04","樱花季纪念卡"),new Sale("05","樱花季纪念杯")};
                Sale[] saleFeb = { new Sale("06", "樱花手表"), new Sale("07", "樱花手环") };
                Sale[] saleMar = { new Sale("08", "樱花节大礼包"), new Sale("06", "樱花手表"), new Sale("07", "樱花手环") };
                double[] dbJan = { 30, 150, 340, 30, 170 };
                double[] dbFeb = { 480, 380 };
                double[] dbMar = { 88, 480, 380 };

                while (true)
                {
                    Console.WriteLine("本产品只提供1，2，3月销售明细，请输入您所要查询的月份：\n退出请按“0”");

                    //将数字的字符串转换成32位等效整数
                    int month = int.Parse(Console.ReadLine());
                    if (month == 0)
                    {
                        break;
                    }
                    switch (month)
                    {
                        case 1:
                            Console.WriteLine("一月份的商品明细如下：");
                            Sale.showInfo(saleJan);
                            Console.WriteLine("一月大屋顶文化节总销售额：" + Sale.CalAmount<double>(dbJan));
                            break;
                        case 2:
                            Console.WriteLine("二月份的商品明细如下：");
                            Sale.showInfo(saleFeb);
                            Console.WriteLine("二月大屋顶文化节总销售额：" + Sale.CalAmount<double>(dbFeb));
                            break;
                        case 3:
                            Console.WriteLine("三月份的商品明细如下：");
                            Sale.showInfo(saleMar);
                            Console.WriteLine("三月大屋顶文化节总销售额：" + Sale.CalAmount<double>(dbMar));
                            break;
                            
                        default:
                            Console.WriteLine("该月份未统计。");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("输入数据类型有误");
            }
            Console.ReadKey();
       }
    }

    /*
     * 声明一个接口，一定要让一个类去实现接口
    interface Information
    {
        //接口必须实现里面的内容
        string Code
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
    }

    */
    public class Sale
    {
        private string code;//产品编号
        private string name;//产品名称

        //访问器
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //定义一个构造函数
        public Sale(string code,string name)
        {
            Code = code;
            Name = name;
        }

        public static void showInfo(Sale[] sales)
        {
            foreach(Sale s in sales)
            {
                Console.WriteLine("商品编号：" + s.Code + "商品名称：" + s.Name);
            }
        }


        //public static double CalAmount(double[] amount)
        //{
        //    double sum = 0;
        //    foreach(double ant in amount)
        //    {
        //        sum += ant;
        //    }
        //    return sum;
        //}
        //泛型
        public static double CalAmount<T>(T[] amount)
        {
            double sum = 0;
            foreach (T ant in amount)
            {
                sum =sum+Convert.ToDouble( ant);
            }
            return sum;
        }

    }
}
