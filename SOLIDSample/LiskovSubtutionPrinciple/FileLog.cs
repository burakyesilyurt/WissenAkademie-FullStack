using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtutionPrinciple
{
    public abstract class FileLog : Log
    {
        public override void LogContent(string logMessage)
        {
            //TODO : Open Or Create File
            //TODO : Create Log Content
            //TODO : Save Log To File
            //TODO : Close File
        }
    }
}
