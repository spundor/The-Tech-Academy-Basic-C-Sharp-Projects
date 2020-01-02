using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of data type Number & assign an amount to it
            Number number = new Number();
            number.Amount = 7.5m;

            //print to console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
