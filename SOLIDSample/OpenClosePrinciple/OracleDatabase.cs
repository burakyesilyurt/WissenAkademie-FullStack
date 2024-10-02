using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class OracleDatabase : IDatabase
    {
        public void AddDatabase(Employee emp)
        {
            InsertOracleDB();
        }

        private void InsertOracleDB()
        {
            Console.WriteLine("Insert Oracle DB");
        }
    }
}
