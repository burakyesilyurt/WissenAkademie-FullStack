using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public class DepoServis : IDepoServisi, IYakitDepoServisi
    {
        public void ArabayaBenzinAl(Araba araba)
        {
            if (araba.BenzinSeviyesi < 100)
                araba.BenzinSeviyesi = 100;
        }

        public void ArabayaBenzinAl(Araba araba, int benzinSeviyesi)
        {
            if (araba.BenzinSeviyesi < 100 && araba.BenzinSeviyesi > 0 && benzinSeviyesi <= (100 - araba.BenzinSeviyesi))
                araba.BenzinSeviyesi = benzinSeviyesi;
        }

        public bool DepoBosMu(Araba araba)
        {
            return araba.BenzinSeviyesi <= 0;
        }

        public int DepodakiBosYer(Araba araba)
        {
            return 100 - araba.BenzinSeviyesi;
        }

        public bool DepoDoluMu(Araba araba)
        {
            return araba.BenzinSeviyesi == 100;
        }
    }
}
