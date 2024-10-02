using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosePrinciple.OCP.CustomExceptions;

namespace OpenClosePrinciple.OCP
{
    public class MotorServis
    {
        public IDepoServisi depoServis;
        public MotorServis()
        {
            depoServis = new DepoServis();    
        }

        public MotorServis(IDepoServisi _depoServis)
        {
            this.depoServis = _depoServis;
        }

        public bool MotorCalisiyorMu(Araba araba)
        {
            return araba.MotorDurumu;
        }

        public void MotorCalistir(Araba araba)
        {
            if (depoServis.DepoBosMu(araba))
                throw new BenzinYokException("Arabada Yakıt Yok");

            if (MotorCalisiyorMu(araba))
                throw new MotorZatenCalisiyorException("Motor Zaten Çalışıyor");

            araba.MotorDurumu = true;
        }

        public void MotoruDurdur(Araba araba)
        {
            if (!MotorCalisiyorMu(araba))
                throw new MotorZatenCalismiyorException("Motor Zaten Çalışmıyor");

            araba.MotorDurumu = false;
        }
    }
}
