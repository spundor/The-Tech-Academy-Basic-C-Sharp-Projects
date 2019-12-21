using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2NumsFix
{
    class Equation
    {
        //create class, create method that takes 2 integers as parameters
        //(1 parameter is optional); perform math operation
        public int Multiplier(int userInputOne, int userInputTwo = 0)
        {
            int MultAnswer = ((userInputOne + userInputTwo) * userInputOne);
            return MultAnswer;
        }
    }
}
