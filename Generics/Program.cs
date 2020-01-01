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
            Employee<string> name = new Employee<string>();
            name.firstName = "Sample";
            name.lastName = "Student";
            name.ID = 1;
            name.ID = 2;

            // 3.instantiate 'Employee' object with data type string as it's generic parameter
            Employee<string> stringThing = new Employee<string>();
            stringThing.things = new List<string>() { "thing1", "thing2", "thing3", "thing4" };
            stringThing.printThings(stringThing.things);

            //4. Instantiate an Employee object with type "int" as its generic parameter. 
            //Assign a list of integers as the property value of things.
            Employee<int> intThing = new Employee<int>();
            intThing.things = new List<int>() { 1, 3, 6, 9};
            intThing.printThings(intThing.things);

            //call SayName() method on 'name' object
            name.SayName();
            

            //using polymorphism intantiate object of type 'IQuittable', call QUit() method
            IQuittable quit = new Employee<string>();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
