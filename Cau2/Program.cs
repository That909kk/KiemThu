using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            Console.Write("\nNhap x: ");
            float x = float.Parse(Console.ReadLine());
            CanBac3 canBac3 = new CanBac3();
            a = canBac3.sqrt3(x);
            Console.WriteLine($"ket qua = {x:F2}");
        }
    }
}
