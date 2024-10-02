using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static SOLIDSample.SingleResponsibilty.CustomExceptions;

namespace SOLIDSample.SingleResponsibilty
{
    public class MotorServisi
    {
        private DepoServisi deposervisi;

        public MotorServisi()
        {
            deposervisi = new DepoServisi();
        }

        public MotorServisi(DepoServisi _deposervisi)
        {
            this.deposervisi = _deposervisi;
        }

        public bool MotorCalisyorMu(Araba araba) => araba.MotorDurumu;

        public void MotorCalistir(Araba araba)
        {
            if (deposervisi.DepoBosMu(araba))
                throw new BenzinYokException("Arabada Yakıt Yok");

            if (MotorCalisyorMu(araba))
                throw new MotorZatenCalisiyorException("Motor Zaten Çalışıyor");

            araba.MotorDurumu = true;
        }

        public void MotorDurdur(Araba araba)
        {
            if (!MotorCalisyorMu(araba))
                throw new MotorZatenCalismiyorException("Motor zaten çalışmıyor");

            araba.MotorDurumu = false;
        }
    }
}
