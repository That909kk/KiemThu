using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Demo
    {
        public static void Main()
        {
            long s0 = 100;
            long s;
            Bai8 bai8 = new Bai8();
            Console.WriteLine(bai8.Sum(s0,out s));
            Console.WriteLine($"Tổng s khi đó là: {s}");

        }
    }
}
