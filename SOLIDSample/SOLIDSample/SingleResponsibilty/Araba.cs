using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.SingleResponsibilty
{
    public class Araba
    {
        private int benzinSeviyesi;

        public int BenzinSeviyesi
        {
            get { return benzinSeviyesi; }
            set
            {
                benzinSeviyesi = value;
                BildirimServisi.YakitBildirim(value);
            }
        }

        private bool motorDurumu;
        public bool MotorDurumu
        {
            get { return motorDurumu; }
            set
            {
                motorDurumu = value;
                BildirimServisi.MotorDurumu(value);
            }
        }

        public string Renk { get; set; }

        public Araba(string renk)
        {
            this.Renk = renk;
        }

        public Araba(string renk,int benzinSeviyesi)
        {
            this.Renk = renk;
            this.benzinSeviyesi = benzinSeviyesi;
        }

        public override string ToString()
        {
            string str = $"{Renk} li arabanın motoru {(motorDurumu ? "Çalışıyor" : "Çalışmıyor")}\n" +
                $"Benzin Seviyesi : {BenzinSeviyesi}";
            return str;
        }
    }
}