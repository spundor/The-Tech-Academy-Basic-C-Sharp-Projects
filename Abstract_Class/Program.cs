using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Employee object
            Employee name = new Employee();
            name.firstName = "Sample";
            name.lastName = "Student";

            //call SayName() method on 'name' object
            name.SayName();
            

            //using polymorphism intantiate object of type 'IQuittable', call QUit() method
            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
