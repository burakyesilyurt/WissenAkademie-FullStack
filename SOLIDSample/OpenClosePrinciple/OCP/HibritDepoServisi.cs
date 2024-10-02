using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public class HibritDepoServisi : IDepoServisi, IYakitDepoServisi, IElektirkliDepoServisi
    {
        public void ArabayaBenzinAl(Araba araba)
        {
            if (araba.BenzinSeviyesi < 100)
                araba.BenzinSeviyesi = 100;
        }

        public void ArabayaBenzinAl(Araba araba, int benzinSeviyesi)
        {
            if (benzinSeviyesi < 100 && araba.BenzinSeviyesi > 0 && araba.BenzinSeviyesi <= (100 - araba.BenzinSeviyesi))
                araba.BenzinSeviyesi = benzinSeviyesi;
        }

        public bool DepoBosMu(Araba araba)
        {
            return (araba.BenzinSeviyesi <= 0 && araba.ElektrikSeviyesi <= 0);
        }

        public int DepodakiBosYer(Araba araba)
        {
            return 100 - araba.BenzinSeviyesi;
        }

        public bool DepoDoluMu(Araba araba)
        {
            return (araba.BenzinSeviyesi == 100 && araba.ElektrikSeviyesi == 100);
        }

        public int ElektrikliDepodakiBosYer(Araba araba)
        {
            return 100 - araba.ElektrikSeviyesi;
        }

        public Araba SarjEt(Araba araba)
        {
            araba.ElektrikSeviyesi = 100;
            return araba;
        }

        public Araba SarjEt(Araba araba, int seviye)
        {
            araba.ElektrikSeviyesi = seviye;
            return araba;
        }
    }
}
