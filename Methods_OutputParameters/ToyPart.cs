using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_OutputParameters
{
    public class ToyPart
    {
        public ToyPart(string name)
        {
            Name = name;
            Num = 1;

        }
        public string Name { get; set; }
        public int Num { get; set; }

        public void Beep()//behavior of toypart
        {
            Console.WriteLine(Num / 2);
            Console.ReadLine();
        }

        //Create method with output parameters
        public void Boop(out string String1, out string String2)
        {
            Console.WriteLine("Please type something: ");
            String1 = Console.ReadLine();

            Console.WriteLine("Please type something else: ");
            String2 = Console.ReadLine();
        }

        public void Boop(out int Num1, out int Num2)
        {
            Num1 = Num + 7;
            Num2 = Num + Num;
        }
    }
}

