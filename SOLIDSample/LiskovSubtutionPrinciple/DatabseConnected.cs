using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtutionPrinciple
{
    public abstract class DatabseConnected : Log
    {
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
