using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public class CustomExceptions
    {
        public class BenzinYokException : Exception
        {
            public BenzinYokException(string mesaj):base(mesaj)
            {

            }
        }

        public class MotorZatenCalisiyorException : Exception
        {
            public MotorZatenCalisiyorException(string mesaj):base(mesaj)
            {

            }
        }

        public class MotorZatenCalismiyorException:Exception
        {
            public MotorZatenCalismiyorException(string mesaj):base(mesaj)
            {

            }
        }
    }
}
