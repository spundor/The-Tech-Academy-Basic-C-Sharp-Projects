using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to concatenate
            string location1 = "Nashville";
            string location2 = "Los Angeles";

            string airline1 = "Delta";
            string airline2 = "American Airlines";
            string airline3 = "Southwest";

            //concatenate three variables into one string
            Console.WriteLine("Concatenation of strings: " + airline1 + " has a noon flight from " + location1 + " to " + location2 + ".");
            Console.ReadLine();

            //convert string to uppercase letters
            location2 = location2.ToUpper();
            Console.WriteLine(location2);
            Console.ReadLine();

            location1 = location1.ToUpper();
            Console.WriteLine(location1);
            Console.ReadLine();

            //create StringBuilder
            StringBuilder flights = new StringBuilder();

            flights.Append(location1 + " has seven incoming flights from " + location2 + " today.");
            Console.WriteLine(flights);
            Console.ReadLine();
     

            
        }
    }
}
