using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Desert:Dish
    {
        public Desert(double price) : base(price)
        {
            this.Priority = 4;
        }
    }
}
