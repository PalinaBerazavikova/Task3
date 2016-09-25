using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Waiter:Worker
    {
        private List<Table> tablesOfWaiter  = new List<Table>();
        public List<Table> TablesOfWaiter { get { return TablesOfWaiter; } private set { TablesOfWaiter = value; } }



    }
}
