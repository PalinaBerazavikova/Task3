using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Entree:Dish
    {
        public Entree(double price) : base(price)
        {
            this.Priority = 1;
        }
    }
}
