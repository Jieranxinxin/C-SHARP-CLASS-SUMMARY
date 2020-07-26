using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ////第一种方法，集合的 方法，比较麻烦
            //Item[] itemArr = new Item[3]
            //{
            //    new Item("0001","apaid"),
            //     new Item("0002","apaid"),
            //      new Item("0003","apaid")
            //};
            ////上述跟着这进行对比  int[] item = new Item[3] { 1, 2, 3 };
            //Sale saleList = new Sale(itemArr);

            ////item在saleList里能找到值，就可以，一直循环赋值，找不找，循环结束
            //foreach(Item item in saleList)
            //{
            //    Console.WriteLine(item.itemCode);
            //    Console.WriteLine(item.itemName);

            //}


            ////2.在C#中，集合类的方法，比上述方法简单

            //ArrayList salelist = new ArrayList();
            //salelist.Add("0001" );
            //salelist.Add("ipad");
            //salelist.Add("0002");
            //salelist.Add( "mp2");

            //foreach(string salestr in salelist)
            //{
            //    Console.WriteLine(salestr);
            //}

            //3.哈希表的方法，更简单

            ArrayList salelist = new ArrayList();
            Hashtable saleTable = new Hashtable();
            saleTable.Add("1001", "电脑");
            saleTable.Add("1002", "手机");
            saleTable.Add("1003", "ipaid");
            salelist.Add(saleTable);

            for(int j=0; j < salelist.Count; j++)
            {
                //没有办法，将salelist转换，只能强转
                Hashtable table = (Hashtable)salelist[j];
                foreach(string key in table.Keys)
                {
                    //因为本来要输出的是字符串
                    Console.WriteLine("{0}:{1}",key,table[key]);
                }
            }

            Console.ReadKey();

        }
    }
}
