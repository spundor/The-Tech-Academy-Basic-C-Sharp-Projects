using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Person
    {
        //declare properties 'firstName' and 'lastName'
        public string firstName { get; set; }
        public string lastName { get; set; }

        //crate virtual method in order to implement in outside class
        public virtual void SayName()
        {
            Console.WriteLine("Employee: " + firstName + " " + lastName);
        }
    }
}
