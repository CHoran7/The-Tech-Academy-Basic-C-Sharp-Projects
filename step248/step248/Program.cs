using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step248
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                Console.WriteLine("Adding new employees");

                var employee = new Employee
                {
                    FirstName = "Cole",
                    LastName = "Horan",
                    StartDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Employees.Add(employee);

                var employee1 = new Employee
                {
                    FirstName = "Mark",
                    LastName = "Lewis",
                    StartDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Employees.Add(employee1);

                var employee2 = new Employee
                {
                    FirstName = "Mike",
                    LastName = "Gonzoles",
                    StartDate = DateTime.Parse("11/16/18")
                };

                context.Employees.Add(employee2);
                context.SaveChanges();

                var employees = (from e in context.Employees orderby e.FirstName select e).ToList<Employee>();

                Console.WriteLine("Retrieve all Employees from the database:");

                foreach (var emplye in employees)
                {
                    string name = emplye.FirstName + " " + emplye.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", emplye.ID, name);
                }

                Console.ReadLine();
            }
        }
    }
}
