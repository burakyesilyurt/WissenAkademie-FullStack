using InterfaceSegragation.ISP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation.ISP.ValidUsage.Concreate
{
    public class Stoper : IFutbolcu, IForvet, IStoper
    {
        public void DefansYap()
        {
            Console.WriteLine("Stoper Defans Yap");
        }

        public void GolAt()
        {
            Console.WriteLine("Stoper Gol At");
        }

        public void PasAt()
        {
            Console.WriteLine("Stoper Pas At");
        }
    }
}
