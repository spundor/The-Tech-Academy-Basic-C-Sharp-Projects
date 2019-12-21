using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_OutputParameters1
{
    static class Program
    {
        static void Main(string[] args)
        {
            //instantiate "Equation" class object
            Equation equation = new Equation();

            //declare integer input variables
            int userInputNum1 = 0;
            int userInputNum2 = 0;

            //prompt user to enter a number
            bool TryAgain = true;

            while (TryAgain)
            {
                try
                {
                    //ask user to enter an integer
                    Console.WriteLine("Enter an integer: ");
                    userInputNum1 = Convert.ToInt32(Console.ReadLine());
                    //boolean TryAgain changed to 'false' if input parameters met
                    TryAgain = false;
                }
                catch (FormatException)//catch invalid input values
                {
                    Console.WriteLine("Please enter a whole number...");
                    Console.ReadLine();
                }
                catch (DivideByZeroException)//catch if user enter a zero
                {
                    Console.WriteLine("Please enter an integer greater than zero...");
                    Console.ReadLine();
                }
            }

            //prompt user to enter a second integer
            Console.WriteLine("Please enter a second integer: ");
          
          
                
                userInputNum2 = Convert.ToInt32(Console.ReadLine());
          
            //call Division method from Equation and print results
            equation.Division(userInputNum1);
            equation.Multiply(userInputNum1, out int Output, userInputNum2);
            equation.Multiply(userInputNum1);

            //print to console
            Console.WriteLine(userInputNum1 + " multiplied by " + userInputNum2 + " equals " + Output + "\n" + userInputNum1 + " multiplied by 5 equals " + equation.Multiply(userInputNum1));
            Console.ReadLine();

        }
    }
}
