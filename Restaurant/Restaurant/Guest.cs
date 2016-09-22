using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Guest
    {
        private Room myRoom;
        public Room MyRoom { get { return myRoom; } private set { myRoom = value; } }
        private Table myTable;
        public Table MyTable { get { return myTable; } private set { myTable = value; } }
    }

    public void ChooseRoom(string room)
    {
        switch (room)
        {
            case "smoke":
                this.MyRoom = new RoomForSmokers();
                break;
        }
    }
}
