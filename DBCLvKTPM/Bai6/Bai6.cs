using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class Bai6
    {
        public Bai6()
        {
        }
        /* Hàm trả về "Vô số nghiệm", "Vô nghiệm", "Có 1 nghiệm", "Có 2 nghiệm phân biệt", 
* "Có nghiệm kép" tùy theo a,b,c. 
* Hàm nhận hai kết quả x1, x2 là nghiệm của phương trình. 
* Nếu nghiệm không được xác định (vô nghiệm, vô số nghiệm) thì x1 = x2 = NaN. 
*/
      public string SolveQuadratic(int a, int b, int c, out float x1, out float x2)
        {
            x1 = 0;
            x2 = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        return "Vô số nghiệm";
                    }
                    return "Vô nghiệm";
                }
                x1 = -c / b;
                return "Có 1 nghiệm";
            }
            float delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "Vô nghiệm";
            }
            if (delta == 0)
            {
                x1 = -b / (2 * a);
                return "Có nghiệm kép";
            }
            x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
            return "Có 2 nghiệm phân biệt x1= " + x1 + " x2=" + x2;
        }
    }
}
