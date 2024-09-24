using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.EFCore.Domain
{
    public class PersonelDetail
    {
        public int PersonelDetailID {  get; set; }
        public int PersonelID {  get; set; }
        public Personel Personel { get; set; }

        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Address {  get; set; }
    }
}
