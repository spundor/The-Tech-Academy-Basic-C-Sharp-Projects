using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            //ask user to enter package weight
            Console.WriteLine("Enter the weight of your package, in pounds (lb):");
            float packageWeight = Convert.ToUInt16(Console.ReadLine());
            
            //weight limit if-statement
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //input package width
            Console.WriteLine("Enter the package width in inches (in):");
            float packageWidth = Convert.ToUInt16(Console.ReadLine());

            //input package height
            Console.WriteLine("Enter the package height in inches (in):");
            float packageHeight = Convert.ToUInt16(Console.ReadLine());

            //input package length
            Console.WriteLine("Enter the package length in inches (in):");
            float packageLength = Convert.ToUInt16(Console.ReadLine());

            //sum of dimensions mustn't exceed limit
            float dimensions = packageWidth + packageHeight + packageLength;
            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //shipping cost calculation (quote)
            float shippingQuote = (dimensions * packageWeight) / 100;

            //print quote
            Console.WriteLine("Shipping Total: $" + shippingQuote);
            Console.ReadLine();

        }
    }
}
