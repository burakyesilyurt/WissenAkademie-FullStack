using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ElasticSearch : IDatabase
    {
        public void add(Exception exception)
        {
            Console.WriteLine($"Add Exception {exception.Message} to ELK Database");
        }
    }
}
