using System;

namespace MATH_AND_COMPARISON_OPERATORS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //input hourly rate & hours per week of P1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string P1Rate = Console.ReadLine();
            double P1HRate = Convert.ToUInt64(P1Rate);
            Console.WriteLine("Person 1 Hours?");
            string P1Hrs = Console.ReadLine();
            double P1Hours = Convert.ToUInt64(P1Hrs);

            //find and display weekly salary of P1
            double weeklySalaryP1 = P1Hours * P1HRate;
            Console.WriteLine("Weekly Salary of Person 1 is: $" + weeklySalaryP1);

            //input hourly rate & hours per week of P2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string P2Rate = Console.ReadLine();
            double P2HRate = Convert.ToUInt64(P2Rate);
            Console.WriteLine("Person 2 Hours?");
            string P2Hrs = Console.ReadLine();
            double P2Hours = Convert.ToUInt64(P2Hrs);

            //find and display weekly salary of P2
            double weeklySalaryP2 = P2Hours * P2HRate;
            Console.WriteLine("Weekly Salary of Person 1 is: $" + weeklySalaryP2);

            //boolean statement to compare both annual salaries and determine if 'Person 1' makes more than 'Person 2'
            bool compareSalary = weeklySalaryP1 > weeklySalaryP2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compareSalary);


            Console.ReadLine();
        }
    }
}
