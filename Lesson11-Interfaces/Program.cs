namespace Lesson11_Interfaces
{

    interface ICustomer 
    {
        void Print();
    
    }

    interface ICustomer2 
    {
       // void Print2();
        void Print();


    }

    class Customer :  ICustomer2 , ICustomer
    {
        public void Print() {
            Console.WriteLine("Print method");  //compiler confused of dimaond ambiguity

        }
        public void Print2()
        {
            Console.WriteLine("Print method");

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Print();

        }
    }
}

/*
 
 --Notes
1.methods in interface are public
2. multiple class inheritance is not possible in c# , possibe with interfaces
3.interface can inherit another interface
4.

 */