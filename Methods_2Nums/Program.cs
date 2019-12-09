using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class
            Nums Nums1 = new Nums(1, 2);

            //call method using 2 numbers
            Nums.NewMethod(3, 4);

            //call method with parameters by name
            Nums.NewMethod(Nums1.Num1, Nums1.Num2);
        }
    }
}
