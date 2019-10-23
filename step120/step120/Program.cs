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
            Employee<string> employee1 = new Employee<string>();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.ID = 1;
            Employee<string> employee2 = new Employee<string>();
            employee2.FirstName = "Joe";
            employee2.LastName = "Schmoe";
            employee2.ID = 2;
            Employee<string> employee3 = new Employee<string>();
            employee3.FirstName = "Cole";
            employee3.LastName = "Horan";
            employee3.ID = 3;
            Employee<string> employee4 = new Employee<string>();
            employee4.FirstName = "Tucker";
            employee4.LastName = "Horan";
            employee4.ID = 4;
            Employee<string> employee5 = new Employee<string>();
            employee5.FirstName = "CJ";
            employee5.LastName = "Horan";
            employee5.ID = 5;
            Employee<string> employee6 = new Employee<string>();
            employee6.FirstName = "Joe";
            employee6.LastName = "Moore";
            employee6.ID = 6;
            Employee<string> employee7 = new Employee<string>();
            employee7.FirstName = "Nobuki";
            employee7.LastName = "Harata";
            employee7.ID = 7;
            Employee<string> employee8 = new Employee<string>();
            employee8.FirstName = "Husani";
            employee8.LastName = "Newbold";
            employee8.ID = 8;
            Employee<string> employee9 = new Employee<string>();
            employee9.FirstName = "Julian";
            employee9.LastName = "Smith";
            employee9.ID = 9;
            Employee<string> employee10 = new Employee<string>();
            employee10.FirstName = "Zach";
            employee10.LastName = "Ireland";
            employee10.ID = 10; 

            List<Employee<string>> employees = new List<Employee<string>>(){employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            List<Employee<string>> joes = new List<Employee<string>>();

            foreach (Employee<string> employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee<string>> joeList = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee<string>> idList = employees.Where(x => x.ID > 5).ToList();

            //employee.SayName();
            //IQuittable quittable = new Employee();
            //quittable.Quit();
            //bool compare = employee == employee;
            //Console.WriteLine(compare);
            //Employee<String> employee = new Employee<string>();
            //employee.Things = new List<string>() { "Cole", "Tucker", "CJ" };
            //Employee<int> employee1 = new Employee<int>();
            //employee1.Things = new List<int>() { 1, 2, 3 };
            //foreach(String thing in employee.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //foreach(int thing in employee1.Things)
            //{
            //    Console.WriteLine(thing);
            //}
        }
    }
}
