namespace Lesson19_EqualsDemo
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object? obj)
        {
            //return base.equals(obj);
            if (obj == null)
                return false;
            if (!(obj is Customer)) return false;

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;



        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();

            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }



        internal class Program
        {
            static void Main(string[] args)
            {
                int firstNumber = 10;
                int secondNumber = 10;

                //Console.WriteLine(firstNumber == secondNumber);
                //Console.WriteLine(firstNumber.Equals(secondNumber));


                Customer firstCustomer = new Customer { FirstName = "Tina", LastName = "Jerry" };
                Customer secondCustomer = new Customer { FirstName = "Tina", LastName = "Jerry" };
                //secondCustomer=firstCustomer;


                //Console.WriteLine(firstCustomer==secondCustomer);

                //Console.WriteLine(firstCustomer.Equals(secondCustomer));

                Console.WriteLine(firstCustomer.GetHashCode());
                Console.WriteLine(secondCustomer.GetHashCode());



            }
        }
    }
}