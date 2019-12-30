using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee: Person, IQuittable
    {
        //implement the SayName() method with the keyword 'override' to access within the abstract class 'Person'
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("ENTER to quit...");
            Console.ReadLine();
        }
    }
}
