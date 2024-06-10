namespace Lesson15_DelegateUseCaseDemo
{
    public delegate bool IsPromotable(Employee employee);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee { Id = 1, Name = "John", Experience = 2, Salary = 5000 };
            employees[1] = new Employee { Id = 2, Name = "Tina", Experience = 5, Salary = 10000 };
            employees[2] = new Employee { Id = 3, Name = "Jerry", Experience = 10, Salary = 50000 };

            IsPromotable isPromotable = new IsPromotable(PromoteEmployee);
            Employee.PromoteEmployee(employees, isPromotable);

        }

        public static bool PromoteEmployee(Employee employee)
        {
            if (employee.Salary >= 10000) 
                return true;
            return false;
        }
    }
}
