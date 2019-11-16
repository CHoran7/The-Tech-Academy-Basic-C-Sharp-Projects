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

                var location = new Location
                {
                    Address = "7887 Cicero Ct",
                    HomeOwner = "Pffier"
                };

                var start = new Start
                {
                    Employee = employee,
                    Location = location,
                    HourlyWage = 15.00
                };

                context.Employees.Add(employee);
                context.Locations.Add(location);
                context.Starts.Add(start);

                var employee1 = new Employee
                {
                    FirstName = "Mark",
                    LastName = "Lewis",
                    StartDate = DateTime.Parse(DateTime.Today.ToString())
                };

                var location1 = new Location
                {
                    Address = "7432 Preservation Trail",
                    HomeOwner = "Johnson"
                };

                var start1 = new Start
                {
                    Employee = employee1,
                    Location = location1,
                    HourlyWage = 15.00
                };

                context.Employees.Add(employee1);
                context.Locations.Add(location1);
                context.Starts.Add(start1);

                var employee2 = new Employee
                {
                    FirstName = "Mike",
                    LastName = "Gonzoles",
                    StartDate = DateTime.Parse("11/16/18")
                };

                var location2 = new Location
                {
                    Address = "4021 Pearl St",
                    HomeOwner = "Horan"
                };

                var start2 = new Start
                {
                    Employee = employee2,
                    Location = location2,
                    HourlyWage = 16.00
                };

                context.Employees.Add(employee2);
                context.Locations.Add(location2);
                context.Starts.Add(start2);
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
