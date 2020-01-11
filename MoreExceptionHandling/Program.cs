using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age: ");
            try
            {
                age = Convert.ToInt16(Console.ReadLine());
                if (age == 0) throw new ZeroException();
                if (age < 0) throw new NegativeException();
                bool validAnswer = false;
                while (!validAnswer)
                {
                    Console.Write("And have you had a birthday yet this year? (y or n): ");
                    string answer = Console.ReadLine();
                    if (answer == "y") validAnswer = true;
                    else if (answer == "n")
                    {
                        validAnswer = true;
                        age += 1;
                    }
                    else Console.WriteLine("Please enter y or n!");
                }   
                Console.WriteLine("You were born in {0}.", DateTime.Now.Year - age);
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("Your age cannot be zero. Please try again.");
                Console.ReadLine();
                return;
            }
            catch (NegativeException)
            {
                Console.WriteLine("Your age definetly cannot be negative.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, did you enter something incorrectly?");
                Console.ReadLine();
                return;
            }
        }
    }
}

//1. Ask the user for their age.

//2. Display the year the user was born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if the user enters zero or negative numbers.

//5. Display a general message if an exception was caused by anything else.
