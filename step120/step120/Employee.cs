using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step120
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Employee:");
            base.SayName();
        }
        public void Quit()
        {
            throw new NotImplementedException();
        }

        public static Boolean operator ==(Employee employee, Employee employee1)
        {
            if(employee.ID == employee1.ID)
            {
                Console.WriteLine("The employees are the same.");
                return true;
            }
            else
            {
                Console.WriteLine("These are different employees.");
                return false;
            }
        }
        public static Boolean operator !=(Employee employee, Employee employee1)
        {
            return true;
        }
        
    }
}
