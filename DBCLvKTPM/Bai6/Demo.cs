using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Demo
    {
        public static void Main(string[] args)
        {
            Bai6 bai6 =new Bai6();
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            float x1, x2;
            Console.WriteLine(bai6.SolveQuadratic(a, b, c, out x1, out x2));
            Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);

        }
    }
}
