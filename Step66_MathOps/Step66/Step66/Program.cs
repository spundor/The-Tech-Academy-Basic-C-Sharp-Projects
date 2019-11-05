using System;


namespace Step66_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enter a number to be multiplied by 50, and print 
            Console.WriteLine("Enter a number to be multiplied by 50:");
            string inputMulti = Console.ReadLine();
            ulong inputMult = Convert.ToUInt64(inputMulti);
            ulong product = 50 * inputMult;
            Console.WriteLine("50 * " + inputMult + " = " + product);

            //input a number to add to 25, and print
            Console.WriteLine("Enter a number to be added to 25:");
            string inputAddition = Console.ReadLine();
            ulong inputAdd = Convert.ToUInt64(inputAddition);
            ulong combined = 25 + inputAdd;
            Console.WriteLine("25 + " + inputAdd + " = " + combined);

            //input number to be divided by 12.5, and print
            Console.WriteLine("Enter a number to be devided by 12.5:");
            string inputDevision = Console.ReadLine();
            ulong inputDev = Convert.ToUInt64(inputDevision);
            double quotient = inputDev / 12.5;
            Console.WriteLine(inputDev + " / 12.5 " + "= " + quotient);

            //input number, check if greater than 50, print boolean value to console
            Console.WriteLine("Enter a number to determine if it is greater than 50:");
            string inputComparison = Console.ReadLine();
            ulong inputComp = Convert.ToUInt64(inputComparison);
            bool comparison = inputComp > 50;
            Console.WriteLine(comparison);

            //input a number to be divided by 7, print the remainder (use modulus operator)
            Console.WriteLine("Enter a number to calculate the remainder after being divided by 7:");
            string inputModulus = Console.ReadLine();
            int inputMod = Convert.ToInt16(inputModulus);
            int modulus = inputMod % 7;
            Console.WriteLine(modulus);

            Console.ReadLine();
        }
    }
}
