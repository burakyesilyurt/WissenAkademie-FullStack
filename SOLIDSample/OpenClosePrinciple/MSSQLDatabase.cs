using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class MSSQLDatabase : IDatabase
    {
        public void AddDatabase(Employee emp)
        {
            if (!EmployeeExists(emp))
                InsertMSSQLDB(emp);
        }

        private void InsertMSSQLDB(Employee emp)
        {
            Console.WriteLine("Insert MSSQL DB");
        }

        private bool EmployeeExists(Employee emp)
        {
            return false;
        }
    }
}
