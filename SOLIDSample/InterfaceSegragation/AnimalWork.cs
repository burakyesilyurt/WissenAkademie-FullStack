using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class AnimalWork : IWork, IEatWork
    {
        public void eat()
        {
            Console.WriteLine("Animal Worker Eat");
        }

        public void work()
        {
            Console.WriteLine("Animal Worker Work");
        }
    }
}
