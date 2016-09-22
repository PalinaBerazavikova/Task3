using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Dish
    {
        //private static string[] types = { "desert", "drink", "salad", "entree" };
        private double price;
        public double Price { get { return price; } private set { price = value; } }
        private string type;
        public string Type { get { return type; } private set { type = value; } }

        public Dish(double price, string type)
        {
            this.Price = price;
            this.Type = type;
        }


        public Dish(double price)
        {
            this.Price = price;
            this.Type = "entree";
        }
    }
}
