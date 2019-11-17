using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            ////create 1D string array
            //string[] stringArray1 = { "Alice", "Amy", "Katherine", "Katarina", "Sasha" };

            ////promt for user input
            //Console.WriteLine("Please enter your name.");
            //string userInput = Console.ReadLine(); //assigns user input to "userInput" variable

            ////add user input variable to string at index 2
            //stringArray1[2] = userInput;

            ////iterate and print to console each indices on separate lines
            //for (int i = 0; i < stringArray1.Length; i++)
            //{
            //    Console.WriteLine("-" + stringArray1[i]);
            //}
            //{
            //    Console.ReadLine();
            //}



            ////infinite loop- above code needs to be commented out before running this loop
            ////for (int j = 0; j>-1;j++)
            ////{
            ////    Console.WriteLine(j);
            ////}

            //// Create a loop where the comparison used to determine
            ////whether to continue iterating the loop is a “<” operator.
            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //    Console.ReadLine();
            //}

            //// Create a loop where the comparison used to determine 
            ////whether to continue iterating the loop is a “<=” operator.
            //for (int j = 0; j <= 10; j++)
            //{
            //    Console.WriteLine(j);
            //    Console.ReadLine();
            //}

            //// list of unique strings
            //List<string> charStrings = new List<string>() { "a", "c", "e", "g", "i", "r", "m", "o", "q", "z", "u", "w", "y" };

            //// list for matching characters
            //List<string> letterMatch = new List<string>();

            ////prompt user to enter a single letter
            //Console.WriteLine("Enter a single letter:");
            //string userString = Console.ReadLine(); // declare variable and assign user input

            //// this for loop iterates through each list entry and returns any index that matches user input
            //for (int l = 0; l < charStrings.Count; l++)

            //{
            //    if (charStrings[l] == userString) // check if an index matches user input
            //    {
            //        letterMatch.Add(charStrings[l]);
            //        Console.WriteLine("-" + charStrings[l]);
            //        break; // exit method once the condition has been met
            ////    }
            ////}

            //////print error message if no match
            ////{
            ////    if (letterMatch.Count == 0)
            ////    {
            ////        Console.WriteLine("Your selection doesn't match any entry within our database.");
            ////    }
            ////}


            ////list of strings with duplicate strings
            //List<string> Students = new List<string>() { "Justin", "Justin", "James", "Jeremy" };

            ////list to store indicies matching user input
            //List<string> Matches = new List<string>();

            ////ask user to input 
            //Console.WriteLine("Please enter a name beginning with the letter J.");
            //string userJName = Console.ReadLine(); //assigns user input to variable
            
            ////loop iterates to match user input (userJName)
            //foreach (string student in Students)
            //{
            //    if (student == userJName)
            //    {
            //        Matches.Add(student); //adding duplicate student name to new list(Matches)                  
            //    }
            //}

            //if (Matches.Count == 0 )
            //{
            //    Console.WriteLine("That name doesn't match this list.");
            //}

            ////print matching data from new list

            //foreach (string i in Matches)
            //{
            //    Console.WriteLine(i + " is a match.");
            //}
            //Console.ReadLine();

            //step 11

            //list of strings with duplicate strings
            List<string> KStudents = new List<string>() { "Kendall", "Kelly", "Kelly", "Karen" };

            //track of iterations of foreach loop
            int NameIndex = 0;
            foreach (string Kstudent in KStudents)
            {
                Console.WriteLine(NameIndex + "." + Kstudent);
                Console.ReadLine();

                //compare name to each previous name
                bool appeared = false;
                for (int i = 0; i<= NameIndex; i++)
                {
                    //if name hasn't appeared yet AND you're at the end of loop
                    if(!appeared && i == NameIndex)
                    {
                        Console.WriteLine(Kstudent + " has only appeared once.");
                        Console.ReadLine();
                    }
                    else if (Kstudent == KStudents[i] && i < NameIndex) //name matches, not at end of loop
                    {
                        Console.WriteLine(Kstudent + " has already appeared in this list at index " + i + ".");
                        appeared = true; 
                    }
                }
                NameIndex++;
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();        
        }
    }
}

