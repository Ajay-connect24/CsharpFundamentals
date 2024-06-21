using System.Text;

namespace DotNetTips
{
    class Customer 
    {
        
    
    }

    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Company
    {
        List<Employee>  employees;

        public Company() 
        {
            employees = new List<Employee>()
            {
                new Employee{ Id=1 ,Name ="Jhon" },
                new Employee{Id=2,Name="Ben"},
                new Employee{ Id=3,Name="Ken"}
            };
        
        }
        public string this[int id]
        {
            get
            {
                Employee employee = employees.Find(x => x.Id == id);
                return employee.Name;
            }

            set
            {
                Employee employee = employees.Find(x => x.Id == id);
                employee.Name = value;
            }
        }

        //public Employee this[int id]
        //{
        //    get
        //    {
        //        Employee employee = employees.Find(x=>x.Id==id);
        //        return employee;
        //    }

        //    set
        //    {
        //        Employee employee =employees.Find(x=>x.Id==id);
        //        employee.Name = value.Name;
        //    }
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // int x = null; //error 
            //int? x = null; 

            //Console.WriteLine(Convert.ToString(x));

            Customer customer = null;

            Console.WriteLine(Convert.ToString(customer)); //throw no error
            
           // Console.WriteLine(customer.ToString()); //throw error coz saying null.ToString is not logical

            Console.WriteLine(customer?.ToString()); //error solved..checks if customer is null else do tostring

            if (customer != null)
            {
                Console.WriteLine(customer.ToString());
            }

            string message = "welcome";
            message = message + "to";
            message = message + "ooty";

            //more memory used and mamamy created and transfered many times while concatenation
            //string is immuatable
            //even if we mofify here , we are changing the location

            StringBuilder str1 = new StringBuilder("Hello world");

            StringBuilder str2 = new StringBuilder();
            str2.Append("welcome");
            str2.Append("to");
            str2.Append("ooty");

            //Stringbuilder  use contiguous memory  allocation and is efficient

            //--------------------------------------------------------------------------------------------------------


            //extension methods where we can create our own methods in a class

            //used where we cant use inheritence..ie in case of sealed class

            int x = 10;
            x.IsGreaterThan(100);

            //------------------------------------------------------------------------------------------------------------


            //performing indexing for a class

            Company company = new Company();

            // Accessing employees using the indexer
            Console.WriteLine(company[2]);
            company[2] = "modifed";
            Console.WriteLine(company[2]);







        }


    }
    public static class IntExtension
    {
        public static bool IsGreaterThan(this int i, int value) => i > value;

        //first parameter must be with this keyword
        //to understnd method is for int keyword
        //if there  is no this keyword then we can only call by IntExtensions.ISGreaterThan( i ,100)
        //
    }
}
