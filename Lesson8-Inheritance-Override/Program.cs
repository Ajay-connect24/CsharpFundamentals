namespace Lesson9_Inheritance_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.PrintFullname();

            FullTimeEmployee employee2 = new FullTimeEmployee();
            employee2.PrintFullname();

            Employee employee3 = new FullTimeEmployee();
            employee3.PrintFullname();

        }
    }
}
