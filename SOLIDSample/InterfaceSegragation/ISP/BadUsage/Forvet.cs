﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation.ISP.BadUsage
{
    public class Forvet : IFutbolcu
    {
        public void DefansYap()
        {
            Console.WriteLine("Yapabilir");
        }

        public void GolAt()
        {
            Console.WriteLine("Yapabilir");
        }

        public void PasAt()
        {
            Console.WriteLine("Yapabilir");
        }

        public void PenaltiKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
