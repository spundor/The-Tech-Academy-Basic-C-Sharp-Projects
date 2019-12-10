using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_OutputParameters
{
    class Program
    {  
        static void Main(string[] args)
        {
            //instantiate ToyParts class
            ToyPart Robot = new ToyPart("Robot");

            Console.WriteLine("Enter number: ", Robot.Name);
            Robot.Num = (Convert.ToInt32(Console.ReadLine()));
            Robot.Beep();

            //overload Boop method (same method name, different arguments)
            Robot.Boop(out int number1, out int number2);
            Console.WriteLine("hi",number1, number2);
            Console.ReadLine();

            Robot.Boop(out string string1, out string string2);
            Console.WriteLine(string1 + " " + string2);
            Console.ReadLine();

        }
    }
}
