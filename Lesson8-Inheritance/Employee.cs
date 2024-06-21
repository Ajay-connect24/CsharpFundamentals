namespace Lesson8_Inheritance_dataHiding
{
    public class Employee
    {
        public string Firstname ="ajay";
        public string Lastname ="lajay";

        public void PrintFullname()
        {
            Console.WriteLine($"Firstname :{Firstname} Lastname : {Lastname}");

        }
    }

    public class FullTimeEmployee : Employee
    {
        public float Salary;
        //public void PrintFullname() //use new keyword for hiding


        
        public new  void PrintFullname()
        {
            //base.PrintFullname();  //accessing base use inside method of child always
            Console.WriteLine($"Firstname :{Firstname} Lastname : {Lastname} -Fulltime");

        }

    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
        public new void  PrintFullname()
        {
            Console.WriteLine($"Firstname :{Firstname} Lastname : {Lastname} - Parttime");

        }

    }






}




