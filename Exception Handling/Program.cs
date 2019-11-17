using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //list of numbers
                List<int> NumsList = new List<int>() { 10, 56, 58, 2165, 856, 1000 };
                Console.WriteLine("Divide by: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int Num in NumsList)
                {
                    Console.WriteLine(Num + "/" + divisor + "=" + Num / divisor + "." + Num % divisor);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole integer.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("Program has continued to execute.");
            Console.ReadLine();
        }    
    }
}
