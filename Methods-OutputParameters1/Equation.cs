using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_OutputParameters1
{
    class Equation
    {
        //create a void method that outputs an integer divided by 2
        public void Division (int userInputNum1)
        {
            int quotient = userInputNum1 / 2;
            Console.WriteLine(userInputNum1 + " divided by 2 equals " + quotient);
            Console.ReadLine();
        }

        //create method with output parameters
        public void Multiply (int userInputNum1, out int Output, int userInputNum2 = 0)
        {
            int product = userInputNum1 * userInputNum2;
            Output = product; //assign value of 'product' to out parameter 'Output'
        }

        //overload a method
        public int Multiply (int userInputNum1)
        {
            int product1 = userInputNum1 * 5;
            return product1;
        }
    }
}
