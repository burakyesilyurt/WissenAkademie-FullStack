using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class AnahtarDegerIkilisi<Tkey ,Tvalue>
    {
        public Tkey ID { get; set; }
        public Tvalue Name { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"ID : {ID.ToString()}\n");
            str.Append($"Name : {Name.ToString()}\n");
            str.Append($"Birth Date : {BirthDate}\n");
            str.Append(new string('*', 100));
            return str.ToString();
        }
    }
}
