using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtutionPrinciple
{
    public class DatabaseLogger : Logger
    {
        public override void closeConnection()
        {
            //TODO : Close Databse Connection
            //TODO : Dispose connectiion
        }

        public override void log(string message)
        {
            //TODO : Create log Content
            openConnection();
            //TODO : Save log to databse
            closeConnection();
        }

        public override void openConnection()
        {
            //TODO : Create new instance connection or get connection from pool-cache  
            //TODO : Open Dtabase Connection
        }
    }
}
