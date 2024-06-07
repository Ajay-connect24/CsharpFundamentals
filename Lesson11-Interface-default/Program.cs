namespace Lesson11_Interface_default
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
        public void Print()    //creating default by imlementing non explicitly
        {
            Console.WriteLine("Print method");
        }
        void ICustomer2.Print()
        {
            Console.WriteLine("Print method");
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
}
