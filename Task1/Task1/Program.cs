using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int var_first = Int32.Parse(Console.ReadLine());
            int var_second = Int32.Parse(Console.ReadLine());

            string config = ConfigurationManager.AppSettings["id"];
            if (String.Equals(config, "configMain")) {
                Console.WriteLine(var_first + var_second);
            }
            if (String.Equals(config, "configClass"))
            {
                Library.Class1 sol = new Library.Class1();
                Console.WriteLine(sol.sum(var_first, var_second));
                Console.WriteLine(sol.subtract(var_first, var_second));
                Console.WriteLine(sol.multiplicat(var_first, var_second));
                Console.WriteLine(sol.div(var_first, var_second));//double parse
            }

        }
    }
}
