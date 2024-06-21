namespace Lesson10_More_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Thomas"     //object initiallisation without ctor

            };

            Console.WriteLine(customer); //returns default tostring
             

            Person person = new Person { Id = 1, Name = "john" };

            Person person1 = person;

            person1.Name = "Test";

            person.Print();
            person1.Print();






        }
    }

    //class Customer
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    // public required string Name { get; set; }


    //    public override string ToString() {
    //        return $"Name : {Name} Id:{Id} ";
    //    } 
    //}
}


/*
 
 --Notes
0.object initiallisation
1.required keyword , then must initiallise the variable
2.without overriding show default to string
3.override tostring
4.use of struct
5.struct is created in stack
6.struct is value type
7.class is a reference type
8.class chnage value on reference while struct does not
9.scope stack memory immediately removed for value types
10.for class reference is deleted but the heap part created by the new keyword will be deleted by clr or garbage collector
11.ctor is possible in struct
12.in senario we need to release data immediately use struct
13.until and unless struct is large
14.
 
 */
