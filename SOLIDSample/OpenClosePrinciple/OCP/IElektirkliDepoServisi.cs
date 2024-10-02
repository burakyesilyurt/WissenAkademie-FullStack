using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public interface IElektirkliDepoServisi
    {
        Araba SarjEt(Araba araba);
        Araba SarjEt(Araba araba, int seviye);
        int ElektrikliDepodakiBosYer(Araba araba);
    }
}
