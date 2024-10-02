using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtutionPrinciple
{
    public abstract class Logger
    {
        public abstract void openConnection();
        public abstract void closeConnection();
        public abstract void log(string message);
    }
}
