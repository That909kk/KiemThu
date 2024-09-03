using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    public class Bai10
    {
        public Bai10()
        {
        }
        public int Largest(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return int.MaxValue;
            }

            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }
    }
}
