using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Bai5

    {
        public Bai5()
        {
        }
    
      public string Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "";
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "";
            }
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            if (a == b || b == c || a == c)
            {
                return "Isosceles";
            }
            return "Scalene";
        }
    }
}
