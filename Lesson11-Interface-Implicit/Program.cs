namespace Lesson11_Interface_explicit

{
    interface ICustomer
    {
        void Print();

    }

    interface ICustomer2
    {

        void Print();


    }

    class Customer : ICustomer2, ICustomer
    {
        void ICustomer2.Print()
        {
            Console.WriteLine("Print method 2");
        }

        void ICustomer.Print()
        {
            Console.WriteLine("Print method 1");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Customer customer = new Customer();
                //customer.Print(); //error can be removed by setting default

                ((ICustomer)customer).Print();   //typecasting

                ((ICustomer2)customer).Print();


                ICustomer customer1 = new Customer();
                customer1.Print();

                //creating ref of interface





            }
        }
    }
}
