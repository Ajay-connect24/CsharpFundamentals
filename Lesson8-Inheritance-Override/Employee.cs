using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Inheritance_Override
{
    public class Employee
    {
        public string Firstname = "ajay";
        public string Lastname = "lajay";

        public virtual void PrintFullname()
        {
            Console.WriteLine($"Firstname :{Firstname} Lastname : {Lastname}");

        }
    }

    public class FullTimeEmployee : Employee
    {
        public float Salary;
        public override void PrintFullname()
        {
          
            Console.WriteLine($"Firstname :{Firstname} Lastname : {Lastname} -Fulltime");

        }

    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
        public  override void PrintFullname()
        {
            Console.WriteLine($"Firstname :{Firstname} Lastname : {Lastname} - Parttime");

        }

    }
}
