using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MathOperations
    {
        public MathOperations()
        {
            Operand = 1; 
        }
        public int Operand { get; set; }

        //squared method
        public static  int Squared(MathOperations num)
        {
            int square = num.Operand * num.Operand;

            return square;
        }

        //Cubed method
        public static int Cubed(MathOperations num)
        {
            int cube = num.Operand * num.Operand * num.Operand;
            return cube;
        }

        //4th root Method
        public static int Fourth(MathOperations num)
        {
            int fourth = num.Operand * num.Operand * num.Operand * num.Operand;
            return fourth;
        }


    }
}
