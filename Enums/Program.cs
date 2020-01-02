using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool switches try/catch loop on/off
            bool tryAgain = true;

            while(tryAgain)
            {
                try
                {
                    //prompt user to enter the current day of the week
                    Console.WriteLine("Please enter the current day of the week: ");
                    string userInput = Console.ReadLine();//assigns user input 
                    string dayToUpper = userInput.ToUpper();//convert string to uppercase and assigns to variable

                    //convert string to enum
                    Days day = (Days)Enum.Parse(typeof(Days), dayToUpper);

                    Console.WriteLine("It's " + userInput + "?!");
                    tryAgain = false; //end loop
                }
                catch (Exception) //catch input that doesn't match enum
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
        //enum for days of the week
        public enum Days
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }
    }
}
