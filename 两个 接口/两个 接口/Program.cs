using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Compute compute = new Compute();
            ICalculateTwoNumbers call = compute;
            Console.WriteLine(call.Add());
            ICalculateThreenumbers call2 = compute;
            Console.WriteLine(call2.Add());

            Console.ReadKey();
        }
    }
}
