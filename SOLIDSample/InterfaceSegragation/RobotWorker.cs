﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class RobotWorker : IWorker
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void pay()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            Console.WriteLine("Robot Worker Work");
        }
    }
}
