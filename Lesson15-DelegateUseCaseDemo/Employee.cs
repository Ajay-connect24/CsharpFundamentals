using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson15_DelegateUseCaseDemo.Program;

namespace Lesson15_DelegateUseCaseDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(Employee[] employees,IsPromotable isPromotable)
        {
            foreach (Employee employee in employees)
            {
                if (isPromotable(employee)) { Console.WriteLine(employee.Name); }

            }
        }
    }
}
