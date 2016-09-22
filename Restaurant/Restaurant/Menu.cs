using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Menu
    {
        private List<Dish> currentMenu = new List<Dish>();
        public List<Dish> CurrentMenu { get { return currentMenu; } private set { currentMenu = value; } }

        public void CreateMenu()
        {
            Dish cake = new Dish(12.3, "desert");
            Dish tea = new Dish(2.5, "drink");
            Dish greeceSalad = new Dish(22.0, "salad");
            Dish beef = new Dish(122.8);
        }
    }
}
