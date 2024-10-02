using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ExceptionReporter
    {
        private IDatabase database;

        public ExceptionReporter(IDatabase _database)
        {
            this.database = _database;
        }

        public void AddException(Exception exception)
        {
            database.add(exception);
        }
    }
}
