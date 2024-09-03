using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class Bai7
    {
        int chiSoCu, chiSoMoi;

        public Bai7(int chiSoCu, int chiSoMoi)
        {
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
        }
        public double TinhTienDien(int chiSoCu, int chiSoMoi)
        {
            double tienDien = 0;
            int soKwh = chiSoMoi - chiSoCu;
            if (soKwh < 0)
            {
                tienDien = -1;
            }
            else
            {
                if (soKwh >= 0 && soKwh <= 50)
                {
                    tienDien = soKwh * 1484;
                    tienDien = tienDien + tienDien * 0.1;
                }
                else
                {
                    if (soKwh > 50 && soKwh <= 100)
                    {
                        tienDien = soKwh * 1533;
                        tienDien = tienDien + tienDien * 0.1;
                    }
                    else
                    {
                        if (soKwh > 100 && soKwh <= 200)
                        {
                            tienDien = soKwh * 1786;
                            tienDien = tienDien + tienDien * 0.1;
                        }
                        else
                        {
                            if (soKwh > 200 && soKwh <= 300)
                            {
                                tienDien = soKwh * 2242;
                                tienDien = tienDien + tienDien * 0.1;
                            }
                            else
                            {
                                if (soKwh > 300 && soKwh <= 400)
                                {
                                    tienDien = soKwh * 2503;
                                    tienDien = tienDien + tienDien * 0.1;
                                }
                                else
                                {
                                    tienDien = soKwh * 2587;
                                    tienDien = tienDien + tienDien * 0.1;
                                }
                            }
                        }
                    }
                }
            }
            return tienDien;
        }
    }
}
