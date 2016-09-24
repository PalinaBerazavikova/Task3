using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{//
    class Order
    {
        private List<Dish> currentOrder = new List<Dish>();
        public List<Dish> CurrentOrder { get { return currentOrder; } private set { currentOrder = value; } }
    }
}
