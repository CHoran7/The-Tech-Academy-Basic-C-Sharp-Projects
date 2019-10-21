using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 1;
            Employee employee1 = new Employee();
            employee.FirstName = "Joe";
            employee.LastName = "Schmoe";
            employee.ID = 2;
            employee.SayName();
            //IQuittable quittable = new Employee();
            //quittable.Quit();
            bool compare = employee == employee;
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
}
