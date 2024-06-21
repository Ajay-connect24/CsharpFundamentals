namespace Lesson5_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.PrintFullname();
            Customer customer2 = new Customer("John","Wick");
            customer2.PrintFullname();
        }
    }
}

/*
1.Creating seperate class using GUI add option
2.private class
3.constructor used to initialise private field outside of class
4.ctor + tab => constructor
5.constructor invoked by framework and not by used
6.default constructor ; overloaded by user defined constructor => create empty constructor to avoid error
7.using {this} to chain constructor for default values in default constructor




 
*/