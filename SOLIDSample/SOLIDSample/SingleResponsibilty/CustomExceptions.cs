using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.SingleResponsibilty
{
    public class CustomExceptions
    {
        public class BenzinYokException : Exception
        {
            public BenzinYokException(string message) : base(message)
            {

            }
        }

        public class MotorZatenCalisiyorException : Exception
        {
            public MotorZatenCalisiyorException(string message) : base(message)
            {

            }
        }

        public class MotorZatenCalismiyorException : Exception
        {
            public MotorZatenCalismiyorException(string message) : base(message)
            {

            }
        }
    }
}
