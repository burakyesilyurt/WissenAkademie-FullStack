using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtutionPrinciple
{
    public class FileLogger : Logger
    {
        public override void closeConnection()
        {
            throw new NotImplementedException();
        }

        public override void log(string message)
        {
            //TODO : Open or Create File
            //TODO : Create Log Content
            //TODO : Save Log content to file
            //TODO : Close File
        }

        public override void openConnection()
        {
            throw new NotImplementedException();
        }
    }
}
