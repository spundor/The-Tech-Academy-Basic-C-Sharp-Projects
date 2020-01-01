using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    //1.
    public class Employee<T> : Person, IQuittable
    {
       public int ID { get; set; }
        //2.
       public List<T> things { get; set; }//List property with generic data type
        
        //overload '==' to compare two objects
        public static bool operator ==(Employee<T> one, Employee<T> two)
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
        public static bool operator !=(Employee<T> one, Employee<T> two)
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //loop through the list 'things' object property in 'things' with generic data type
        public void printThings (List<T> things)
        {
            foreach (T thing in things)
            {
                Console.WriteLine(thing);
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
