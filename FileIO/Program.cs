using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int usernum = 0;
            Console.WriteLine("Enter an integer.");
            usernum = Convert.ToInt32(Console.ReadLine());

            //declare 'numLog' variable & convert 'usernum' to a string
            string numLog = string.Format(Convert.ToString(usernum));
            //log user selection to file pathway
            File.WriteAllText(@"C:\Users\scarb\Logs\step154log.txt",numLog);

            //read text in file and write to console
            string readLog = File.ReadAllText(@"C:\Users\scarb\Logs\step154log.txt");
            Console.WriteLine("\nThe number you selected and logged was {0}.", readLog);
            Console.ReadLine();

        }
    }
}
