using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Demo
    {
        public static void Main(string[] args)
        {
            Bai5 bai5 = new Bai5();
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bai5.Triangle(a, b, c));
        }
    }
}
