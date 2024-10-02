using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.SingleResponsibilty
{
    public static class BildirimServisi
    {
        public static void YakitBildirim(int seviye)
        {
            Console.WriteLine($"Yeni Benzin Seviyesi : {seviye}");
        }

        public static void MotorDurumu(bool motorDurumu)
        {
            Console.WriteLine($"Motor {(motorDurumu ? "Çalıştırıldı" : "Durduruldu")}");
        }

        public static void ArabanınDurumu(Araba araba)
        {
            Console.WriteLine(araba.ToString());
        }
    }
}
