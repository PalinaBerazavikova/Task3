using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Cooker:Worker
    {
        private int numberOfOrders = 0;
        public int NumberOfOrders { get { return numberOfOrders; } private set { numberOfOrders = value; } }

        public void CookOrder(Waiter waiter)
        {
            //waiter.
        }
    }
}
