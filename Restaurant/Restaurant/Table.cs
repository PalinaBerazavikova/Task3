using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Table
    {
        private bool isVacant = true;
        public bool IsVacant { get { return isVacant; } private set { isVacant = value; } }
        private int numberOfChairs;
        public int NumberOfChairs { get { return numberOfChairs; } private set { numberOfChairs = value; } }
        private bool isReserved = false;
        public bool IsReserved { get { return isReserved; } private set { isReserved = value; } }
        private List<Order> tablesOfWaiter = new List<Table>();
        public List<Table> TablesOfWaiter { get { return TablesOfWaiter; } private set { TablesOfWaiter = value; } }


    }
}
