using DependencyInversion.DIP.ValidUsage.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.DIP.ValidUsage.Concrate
{
    public class Restoran
    {
        private readonly List<IUrun> yemekler;

        public Restoran(List<IUrun> _yemekler)
        {
            this.yemekler = _yemekler;
        }

        public void YemekYap()
        {
            foreach (var item in yemekler)
            {
                item.YemekYap();
            }
        }
    }
}
