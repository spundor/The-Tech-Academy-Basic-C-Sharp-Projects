using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        public static string CubeSolution { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            int intInput = Convert.ToInt32(Console.ReadLine());

            //instantiate MathOperations class
            MathOperations Squarednum = new MathOperations();

            //Assign user input to the Operand property
            Squarednum.Operand = intInput;

            //pass class instance to method; assign return to variable
            int SquareSolution = MathOperations.Squared(Squarednum);

            //write to console
            Console.WriteLine(intInput + " squared = " + SquareSolution);

            Console.ReadLine();


            //instantiate 
            MathOperations Cubednum = new MathOperations();
            //assign user input to Operand property
            Cubednum.Operand = intInput;
            //pass class instance to method; assign return to variable
            int CubeSolution = MathOperations.Cubed(Cubednum);
            //write to console
            Console.WriteLine(intInput + " cubed = " + CubeSolution);
            Console.ReadLine();


            //instantiate 
            MathOperations Fourthnum = new MathOperations();
            //assign user input to Operand property
            Fourthnum.Operand = intInput;
            //pass class instance to method; assign return to variable
            int FourthSolution = MathOperations.Fourth(Fourthnum);
            //write to console
            Console.WriteLine(intInput + "'s fourth root = " + FourthSolution);
            Console.ReadLine();
        }
    }
}
