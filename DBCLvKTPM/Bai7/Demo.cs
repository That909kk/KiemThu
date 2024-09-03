using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class Demo
    {
        public static void Main() {
            Bai7 bai7 = new Bai7(100, 200);
            double tienDien = bai7.TinhTienDien(100, 200);
            Console.WriteLine(tienDien);

            Bai7 b7 = new Bai7(0, 50);
            double tienDie = bai7.TinhTienDien(0, 50);
            Console.WriteLine(tienDie);
        }
    }
}
