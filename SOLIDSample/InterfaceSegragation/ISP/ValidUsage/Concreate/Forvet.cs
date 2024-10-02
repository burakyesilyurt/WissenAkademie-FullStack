
using InterfaceSegragation.ISP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation.ISP.ValidUsage.Concreate
{
    public class Forvet : IFutbolcu, IForvet, IStoper
    {
        public void DefansYap()
        {
            Console.WriteLine("Forvet Defans At");
        }

        public void GolAt()
        {
            Console.WriteLine("Forvet Gol At");
        }

        public void PasAt()
        {
            Console.WriteLine("Forvet Pas At");
        }
    }
}
