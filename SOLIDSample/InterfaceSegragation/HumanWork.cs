using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class HumanWork : IWork, IEatWork, IPayableWork
    {
        public void eat()
        {
            Console.WriteLine("Human Worker Eat");
        }

        public void pay()
        {
            Console.WriteLine("Human Worker Pay");
        }

        public void work()
        {
            Console.WriteLine("Human Worker Work");
        }
    }
}
