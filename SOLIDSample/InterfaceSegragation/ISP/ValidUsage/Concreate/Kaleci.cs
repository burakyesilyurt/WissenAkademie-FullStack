using InterfaceSegragation.ISP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation.ISP.ValidUsage.Concreate
{
    public class Kaleci : IFutbolcu, IForvet, IStoper, IKaleci
    {
        public void DefansYap()
        {
            Console.WriteLine("Kaleci Defans Yap");
        }

        public void GolAt()
        {
            Console.WriteLine("Kaleci Gol At");
        }

        public void PasAt()
        {
            Console.WriteLine("Kaleci Pas At");
        }

        public void PenaltiKurtar()
        {
            Console.WriteLine("Kaleci Penaltı Kurtar");
        }
    }
}
