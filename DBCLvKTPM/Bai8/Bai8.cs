using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Bai8
    {
        public Bai8()
        {
        }
     public long Sum(long s0, out long s)
        {
            long k = 1;
            s = 0;
            while (s <= s0)
            {
                s += k;
                k++;
            }
            return k;
        }

        internal long Sum(int v)
        {
            throw new NotImplementedException();
        }
    }
}
