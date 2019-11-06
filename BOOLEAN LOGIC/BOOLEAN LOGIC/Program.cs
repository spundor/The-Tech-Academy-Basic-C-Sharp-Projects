using System;

namespace BOOLEAN_LOGIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Have you ever had a DUI? (Please answer with 'true' or 'false')");
            bool dui = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = int.Parse(Console.ReadLine());

            bool approved = age > 15 && dui == false && ticket <= 3;
            Console.WriteLine("Approved?" + approved);


            Console.ReadLine();
        }
    }
}
