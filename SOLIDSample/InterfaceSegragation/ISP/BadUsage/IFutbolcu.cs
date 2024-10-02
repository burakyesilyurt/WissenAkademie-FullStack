using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation.ISP.BadUsage
{
    public interface IFutbolcu
    {
        void DefansYap();
        void GolAt();
        void PasAt();
        void PenaltiKurtar();
    }
}
