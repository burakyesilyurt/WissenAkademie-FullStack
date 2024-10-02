using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public interface IYakitDepoServisi
    {
        void ArabayaBenzinAl(Araba araba);
        void ArabayaBenzinAl(Araba araba, int benzinSeviyesi);
        int DepodakiBosYer(Araba araba);
    }
}
