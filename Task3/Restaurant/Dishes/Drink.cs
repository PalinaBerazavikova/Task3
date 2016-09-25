using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Drink:Dish
    {
        public Drink(double price) : base(price)
        {
            this.Priority = 1;
        }
}
}
