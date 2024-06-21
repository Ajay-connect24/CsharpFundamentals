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
            Console.WriteLine("Print method default ");
        }
        void ICustomer2.Print()
        {
            Console.WriteLine("Print method2");
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
