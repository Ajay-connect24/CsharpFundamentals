namespace Lesson23_Lists
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 3, 6, 9, 5, 10 };

            numbers.Sort();
            numbers.ForEach(x => Console.WriteLine(x));
            numbers.Count();
            numbers.Count(x => x % 2 == 0);
            numbers.Max();
            numbers.Min();
            numbers.Reverse();
            numbers.ForEach(x => Console.WriteLine(x));

            List<string> values = new List<string>() { "A", "Z", "K" };
            values.Sort();
            values.ForEach(x => Console.WriteLine(x));


            List<Customer> customers = new List<Customer>()
            {
            new Customer() { Id = 1 ,Name="John" ,Salary=50000} ,
            new Customer() { Id = 2 ,Name="Johnny" ,Salary=70000} ,
            new Customer() { Id = 3 ,Name="Johnathan" ,Salary=60000} ,
            };

            customers.Sort();
            customers.ForEach(customer => Console.WriteLine($"Id :{customer.Id} Name :{customer.Name} Salary :{customer.Salary}"));

            IEnumerable<int> nums = new List<int>();




        }
    }

    class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer? other)
        {
            if (this.Salary > other.Salary) return 1;
            else if (this.Salary < other.Salary) return -1;
            else return 0;
        }
    }
}

//by default i compareable is in descending order