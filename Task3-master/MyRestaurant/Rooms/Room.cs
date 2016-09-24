using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Room
    {
        protected List<Table> tables = new List<Table>();
        public List<Table> Tables { get { return tables; } set { tables = value; } }
        protected string nameOfRoom = "no-smoke";
        public string NameOfRoom { get { return nameOfRoom; } set { nameOfRoom = value; } }

        public Room()
        {
            Table table1 = new Table(2);
            Table table2 = new Table(2);
            Table table3 = new Table(4);
            Table table4 = new Table(4);
            Table table5 = new Table(4);
            Table table6 = new Table(6);
            this.tables.Add(table1);
            this.tables.Add(table2);
            this.tables.Add(table3);
            this.tables.Add(table4);
            this.tables.Add(table5);
            this.tables.Add(table6);
        }
    }
}
