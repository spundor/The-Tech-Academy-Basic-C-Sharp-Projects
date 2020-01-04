using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> theEmployeeList = new List<Employee>();

            theEmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Apple", EmployeeID = 1 });
            theEmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Byrons", EmployeeID = 2 });
            theEmployeeList.Add(new Employee { FirstName = "Candance", LastName = "Clemens", EmployeeID = 3 });
            theEmployeeList.Add(new Employee { FirstName = "Christine", LastName = "Davidson", EmployeeID = 5 });
            theEmployeeList.Add(new Employee { FirstName = "Erin", LastName = "Edwards", EmployeeID = 6 });
            theEmployeeList.Add(new Employee { FirstName = "Michael", LastName = "Ferguson", EmployeeID = 7 });
            theEmployeeList.Add(new Employee { FirstName = "Sarah", LastName = "Garrison", EmployeeID = 8 });
            theEmployeeList.Add(new Employee { FirstName = "Tarin", LastName = "Horvath", EmployeeID = 9 });
            theEmployeeList.Add(new Employee { FirstName = "Luke", LastName = "Iglesias", EmployeeID = 10 });
            theEmployeeList.Add(new Employee { FirstName = "Farrah", LastName = "Jacobson", EmployeeID = 10 });

            //Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> newList = new List<Employee>();
            foreach (var person in theEmployeeList)
            {
                if (person.FirstName == "Joe")
                {
                    newList.Add(person);
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
            }
            Console.ReadLine();


            //Do the same thing again, but this time with a lambda expression.
            //new List<Employee> (theEmployeeList.Where(x => x.FirstName == "Joe").ToList()).ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

            //Console.ReadLine();


            //4.Using a lambda expression, make a list of all employees with an ID number greater than 5.
            //new List<Employee> (theEmployeeList.Where(x => x.EmployeeID > 5).ToList()).ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

            // Console.ReadLine();

        }

    }
}
