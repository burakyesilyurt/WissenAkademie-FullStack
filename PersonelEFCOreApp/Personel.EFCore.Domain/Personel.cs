using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.EFCore.Domain
{
    public class Personel
    {
        public int PersonelID {  get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string IdentityNumber {  get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Gender {  get; set; }
        public string Department { get; set; }
        public bool IsActive {  get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public PersonelDetail PersonelDetail {  get; set; }
    }
}
