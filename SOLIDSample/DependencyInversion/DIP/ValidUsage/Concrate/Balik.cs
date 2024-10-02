using DependencyInversion.DIP.ValidUsage.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.DIP.ValidUsage.Concrate
{
    public class Balik : IUrun
    {
        public void YemekYap()
        {
            Console.WriteLine("Balık Pişirme Talimatları");
        }
    }
}
