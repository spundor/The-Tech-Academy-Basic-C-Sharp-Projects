using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2NumsFix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate 
            Equation equation = new Equation();
            int userInputOne = 0;
            int userInputTwo = 0;

            //prompt for userInputOne
            Console.WriteLine("Enter a number:");
            userInputOne = Convert.ToInt32(Console.ReadLine());

            //prompt for userInputOne (optional)
            Console.WriteLine("Enter a second number (optional): ");
            string userString = Console.ReadLine();

            //check
            if(userString is "")
            {
                equation.Multiplier(userInputOne); //pass one parameter
            }
            else
            {
                userInputTwo = Convert.ToInt32(userString);
                equation.Multiplier(userInputOne, userInputTwo);
            }

            //print returned value
            Console.WriteLine("\n" + "All input values added together and multiplied by the first number equals " + equation.Multiplier(userInputOne, userInputTwo));
            Console.ReadLine();
        }
    }
}
