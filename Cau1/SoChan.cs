using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    public class SoChan
    {
        public SoChan()
        {
        }
        public int FindFirstEven(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    return number;
                }
            }
            return -1; // Trả về -1 nếu không có số chẵn nào trong mảng
        }
    }
}

