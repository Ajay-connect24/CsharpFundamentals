namespace Lesson8_Inheritance_dataHiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullemployee = new FullTimeEmployee();
            fullemployee.Firstname = "John";
            fullemployee.Lastname = "sam";

            fullemployee.PrintFullname();


            Employee employee = new FullTimeEmployee();
            employee.Firstname = "John";
            employee.Lastname = "sam";

            employee.PrintFullname();

            // even if obj created is of child , base is shown if new keyword used for hiding

            //  FullTimeEmployee baseemployee = new Employee(); THIS CONVERSION IMPLICITLY IS NOT  POSSIBLE WE CAN TYPECAST
            // FullTimeEmployee baseemployee = ((FullTimeEmployee) new Employee()); exception thrown

            Console.WriteLine("type casted");
            ((Employee)fullemployee).PrintFullname();


            Console.WriteLine("ARRAYs");
            Employee[] employee2 = new Employee[3];

            employee2[0] = new Employee();
            employee2[1] = new FullTimeEmployee();
            employee2[2] = new PartTimeEmployee();

            foreach(Employee employee3 in employee2)
            {

                employee3.PrintFullname();
            }




            
           










        }
    }

}

/*
---Notes
1.data hiding vs overriding
2.methods alreay in are inherited from obj class
3.super class will be called first
4. if a method in sub calss is called then the order >> child static ctor >> base static ctor >> base ctor >> child ctor
5.base keyword used to invoke method in superclass; use inside child method
6. FullTimeEmployee employee = new Employee();  not possible
7.









/*
---Notes
1.methods in class are inherited from object class
2.super class will be called first
3.






*/