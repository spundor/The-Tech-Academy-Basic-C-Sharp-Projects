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
            //Console.WriteLine("What should be everyone's new last name?");
            //string userInput = Console.ReadLine(); //assigns user input to "userInput" variable


            ////iterate and print to console each indices on separate lines
            //for (int i = 0; i < stringArray1.Length; i++)
            //{
            //    Console.WriteLine(stringArray1[i] + "'s new last name is: " + userInput + ".");
            //}
            //{
            //    Console.ReadLine();
            //}



            ////#2 infinite loop-above code needs to be commented out before running this loop
            //for (int j = 0; j > -1; j++)
            //{
            //    Console.WriteLine("Press Escape to Exit Loop.");
            //    Console.ReadLine();
            //    Console.WriteLine(j);
            //}
            ////#3 Break infinite loop...This code reminds you to escape after every number.
            ////If wanted to let the infinite loop roll on then break the loop by entering the ESC key.
            //do
            //{
            //    while (Console.KeyAvailable)
            //    {

            //    }
            //} while (Console.ReadKey(true).Key == ConsoleKey.Escape);



            //// #4.Create a loop where the comparison used to determine
            ////whether to continue iterating the loop is a “<” operator.
            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //    Console.ReadLine();
            //}

            ////#5. Create a loop where the comparison used to determine 
            ////whether to continue iterating the loop is a “<=” operator.
            //for (int j = 0; j <= 10; j++)
            //{
            //    Console.WriteLine(j);
            //    Console.ReadLine();
            //}

            //#6.  Create a List of strings where each item in the list is unique. 
            //Ask the user to select text to search for in the List. Create a loop that 
            //iterates through the list and then displays the index of the array that contains matching text on the screen.
            //list of unique strings:
            //List<string> charstrings = new List<string>() { "a", "c", "e", "g", "i", "r", "m", "o", "q", "z", "u", "w", "y" };

            //// list for matching characters
            //List<string> lettermatch = new List<string>();

            ////prompt user to enter a single letter
            //Console.WriteLine("Enter a single letter to find the index of the matching data:");
            //string userstring = Console.ReadLine(); // declare variable and assign user input

            //// this for loop iterates through each list entry and returns any index that matches user input
            //for (int l = 0; l < charstrings.Count; l++)

            //{
            //    if (charstrings[l] == userstring) // check if an index matches user input
            //    {
            //        lettermatch.Add(charstrings[l]);
            //        Console.WriteLine("The index of the matching data is: " + l);
            //        Console.ReadLine();
            //        break;// exit method once the condition has been met
            //    }
            //}

            ////print error message if no match
            //{
            //    if (lettermatch.Count == 0)
            //    {
            //        Console.WriteLine("Your selection doesn't match any entry within our database.");
            //        Console.ReadLine();
            //    }
            //}


        // #9 list of strings with duplicate strings
            List<string> Students = new List<string>() { "Justin", "Justin", "James", "Jeremy" };

            //list to store indicies matching user input
            List<string> Matches = new List<string>();

            //ask user to input 
            Console.WriteLine("Please enter a name beginning with the letter J.");
            string userJName = Console.ReadLine(); //assigns user input to variable

            //loop iterates to match user input (userjname)
   
           for (int z = 0; z < Students.Count; z++)
            {
                if (Students[z] == userJName)
                {
                    Matches.Add(Students[z]); //adding duplicate student name to new list(matches)                  
                    Console.WriteLine("Match located at index: " + z);
                    Console.ReadLine();
                }
            }
   
            
            if (Matches.Count == 0)
            {
                Console.WriteLine("That name doesn't match this list.");
                Console.ReadLine();
            }

         

           //# 11

            //        //list of strings with duplicate strings
            //        List<string> KStudents = new List<string>() { "Kendall", "Kelly", "Kelly", "Karen" };

            ////track of iterations of foreach loop
            //int NameIndex = 0;
            //foreach (string Kstudent in KStudents)
            //{
            //    Console.WriteLine(NameIndex + "." + Kstudent);
            //    Console.ReadLine();

            //    //compare name to each previous name
            //    bool appeared = false;
            //    for (int i = 0; i<= NameIndex; i++)
            //    {
            //        //if name hasn't appeared yet AND you're at the end of loop
            //        if(!appeared && i == NameIndex)
            //        {
            //            Console.WriteLine(Kstudent + " has only appeared once.");
            //            Console.ReadLine();
            //        }
            //        else if (Kstudent == KStudents[i] && i < NameIndex) //name matches, not at end of loop
            //        {
            //            Console.WriteLine(Kstudent + " has already appeared in this list at index " + i + ".");
            //            appeared = true; 
            //        }
            //    }
            //    NameIndex++;
            //    Console.WriteLine(Environment.NewLine);
            //}
            //Console.ReadLine();        
        }
            }
        }
    

