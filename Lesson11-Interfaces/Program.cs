namespace Lesson11_Interfaces
{

    interface ICustomer2 
    {
        void Print();
    
    }

    interface ICustomer
    {
       // void Print2();
        void Print();


    }

    class Customer :  ICustomer , ICustomer2
    {
        public void Print() {
            Console.WriteLine("Print method 1");  //compiler confused of dimaond ambiguity

        }
        public void Print2()
        {
            Console.WriteLine("Print method 2");

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
4.its a contract 
 

 */