using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.DIP.BadUsage
{
    public class Restoran
    {
        Balik balik = new Balik();
        Tavuk tavuk = new Tavuk();

        public void YemekYap()
        {
            balik.BalikPisir();
            tavuk.TavukPisir();
        }
    }
}
