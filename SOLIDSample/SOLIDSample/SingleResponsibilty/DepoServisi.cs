using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.SingleResponsibilty
{
    public class DepoServisi
    {
        public void ArabayaBenzinAl(Araba araba)//depoyu fulle
        {
            if (araba.BenzinSeviyesi < 100)
                araba.BenzinSeviyesi = 100;
        }

        public void ArabayaBenzinAl(Araba araba,int benzinSeviyesi)
        {
            if (araba.BenzinSeviyesi < 100 && araba.BenzinSeviyesi > 0 && benzinSeviyesi <= (100 - araba.BenzinSeviyesi))
                araba.BenzinSeviyesi = benzinSeviyesi;
        }

        public bool DepoBosMu(Araba araba) => araba.BenzinSeviyesi == 0;

        public bool DepoDoluMu(Araba araba) => araba.BenzinSeviyesi == 100;

        public int DepodakiBosYer(Araba araba) => 100 - araba.BenzinSeviyesi;

    }
}
