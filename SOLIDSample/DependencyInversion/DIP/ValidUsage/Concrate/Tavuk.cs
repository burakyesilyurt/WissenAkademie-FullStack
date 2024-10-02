using DependencyInversion.DIP.ValidUsage.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.DIP.ValidUsage.Concrate
{
    public class Tavuk : IUrun
    {
        public void YemekYap()
        {
            Console.WriteLine("Tavuk Pişirme Talimatları");
        }
    }
}
