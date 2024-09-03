using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    public class CanBac3
    {
        public CanBac3()
        {
        }
        public float sqrt3 (float x)
        {
            if (x == 0)
                return 0;
            if(x>0)
                 return (-sqrt3(-x));
            return (float)Math.Exp(Math.Log(x) / 3);
        }
    }
}
