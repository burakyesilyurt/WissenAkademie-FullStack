using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class GenericSinif<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
        public string SirName {  get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Id : {ID}\n");
            str.Append($"Full Name : {Name} {SirName}\n");
            str.Append(new string('*', 100));
            return str.ToString();
        }
    }
}
