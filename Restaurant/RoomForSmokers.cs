using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class RoomForSmokers:Room
    {
        protected bool ashtray = true;
        public bool Ashtray { get { return ashtray; } private set { ashtray = value; } }

        RoomForSmokers()
        {
            this.NameOfRoom = "smoke";
        }
    }
}
