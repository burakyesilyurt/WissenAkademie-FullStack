using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
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

        private int elektrikSeviyesi;
        public int ElektrikSeviyesi
        {
            get { return elektrikSeviyesi; }
            set
            {
                elektrikSeviyesi = value;
                BildirimServisi.ElektrikBildirim(value);

            }
        }

        private bool motorDurumu;
        public bool MotorDurumu
        {
            get { return motorDurumu; }
            set
            {
                motorDurumu = value;
                BildirimServisi.MotorBildirim(value);
            }
        }

        public string Renk { get; set; }

        public Araba(string renk)
        {
            this.Renk = renk;
        }

        public Araba(string renk, int benzinSeviyesi)
        {
            this.Renk = renk;
            this.benzinSeviyesi = benzinSeviyesi;
        }

        public override string ToString()
        {
            string str = $"{Renk} li arabanın motoru {(MotorDurumu ? "Çalışıyor" : "Çalışmıyor")}\n" +
                $"Benzin Seviyesi : {BenzinSeviyesi}\n" +
                $"Elektrik Seviyesi : {elektrikSeviyesi}";
            return str;
        }
    }
}
