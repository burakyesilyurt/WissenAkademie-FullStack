using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class ELKDatabase : IDatabase
    {
        public void AddDatabase(Employee emp)
        {
            InsertELKDB(emp);
        }

        private void InsertELKDB(Employee emp)
        {
            Console.WriteLine("ELK Employee Insert");
        }
    }
}
