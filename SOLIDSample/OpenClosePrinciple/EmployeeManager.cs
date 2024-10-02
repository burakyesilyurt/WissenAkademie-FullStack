using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class EmployeeManager
    {
        private IDatabase db;

        public EmployeeManager(IDatabase _db)
        {
            this.db = _db;
        }

        public void AddEmployee(Employee employee)
        {
            db.AddDatabase(employee);
        }
        //public void AddDatabase(string dbType,Employee emp)
        //{
        //    if(dbType == "MSSQL")
        //    {
        //        MSSQLDatabase mssql = new MSSQLDatabase();
        //        mssql.AddDatabase(emp);
        //    }
        //    else if(dbType == "Oracle")
        //    {
        //        OracleDatabase oracle = new OracleDatabase();
        //        oracle.AddDatabase(emp);
        //    }
        //    else if(dbType == "ELK")
        //    {
        //        //TODO : ELK Insert Employee
        //    }

    }
}

