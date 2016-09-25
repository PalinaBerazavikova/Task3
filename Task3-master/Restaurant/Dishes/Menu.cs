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

        public Menu()
        {
            Desert cake = new Desert(12.3);
            Drink tea = new Drink(2.5);
            Salad greeceSalad = new Salad(22.0);
            Entree beef = new Entree(122.8);
            this.currentMenu.Add(cake);
            this.currentMenu.Add(tea);
            this.currentMenu.Add(greeceSalad);
            this.currentMenu.Add(beef);
        }

    }
}
