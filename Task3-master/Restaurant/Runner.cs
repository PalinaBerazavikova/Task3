using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Runner
    {
        static void Main(string[] args)
        {
            Menu currentMenu = new Restaurant.Menu();
            //RoomForSmokers roomForSmokers = new Restaurant.RoomForSmokers();
            Room room = new Restaurant.Room();

            Console.ReadKey();
        }
    }
}
