using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Prints the current date and time to the console.
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentTime);
            Console.Read();

            //2. Asks the user for a number.
            int userNum = 0;
            Console.WriteLine("Enter a number.");
            Console.ReadLine();
            userNum = Convert.ToInt32(Console.ReadLine());

            //3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("In {0} hours, it will be {1}.", userNum, currentTime.AddHours(userNum).ToShortTimeString());
            Console.ReadLine();
          

        }
    }
}


