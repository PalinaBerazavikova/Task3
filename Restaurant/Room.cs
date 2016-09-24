using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Room
    {
        protected List<Table> tables = new List<Table>();
        public List<Table> Tables { get { return tables; } private set { tables = value; } }
        protected string nameOfRoom = "no-smoke";
        public string NameOfRoom { get { return nameOfRoom; } set { nameOfRoom = value; } }
    }
}
