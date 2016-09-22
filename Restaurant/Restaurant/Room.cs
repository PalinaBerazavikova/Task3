using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Room
    {
        private List<Table> tables = new List<Table>();
        public List<Table> Tables { get { return tables; } private set { tables = value; } }
        private string nameOfRoom = "no-smoke";
        public string NameOfRoom { get { return nameOfRoom; } set { nameOfRoom = value; } }
    }
}
