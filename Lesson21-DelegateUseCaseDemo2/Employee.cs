using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_DelegateUseCaseDemo2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(Employee[] employees, Predicate<Employee> isPromotable)
        {
            foreach (Employee employee in employees)
            {
                if (isPromotable(employee)) { Console.WriteLine(employee.Name); }

            }
        }
    }

    
}
