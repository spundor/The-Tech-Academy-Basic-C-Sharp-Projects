using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
       public int ID { get; set; }
        
        //overload '==' to compare two objects
        public static bool operator ==(Employee one, Employee two)
        {
            if (one.ID == two.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee one, Employee two)
        {
            if (one.ID != two.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
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
