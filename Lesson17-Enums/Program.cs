using System.Security.Cryptography.X509Certificates;

namespace Lesson17_Enums
{
    internal class Program
    {
        enum Gender
        {
            Unknown, Male, Female
        }

        class Customer
        {
            public string Name { get; set; }
            public Gender Gender { get; set; }
        }
        

        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "John",
                Gender = Gender.Unknown

            };
            customers[1] = new Customer
            {
                Name = "Tina",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "abcd",
                Gender = Gender.Unknown
            };

            foreach (Customer customer  in customers)
            {
                Console.WriteLine($"Name is {customer.Name} , Gender is {customer.Gender}");
            }

            Console.WriteLine("3232223");
            Console.WriteLine(Gender.Unknown);


        }

        static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Gender";
            }
        }
    }
}

//enum values are gicen automatically
