namespace Lesson24_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(1, "India");
            countries.Add(2, "USA");
            countries.Add(3, "UK");
            //countries.Add(3, "Iran");


            //Read

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            foreach (KeyValuePair<int, string> keyValuePair in countries)
            {
                Console.WriteLine($"{keyValuePair.Key}-{keyValuePair.Value}");
            }

            Console.WriteLine(countries[2]);

            if (countries.ContainsKey(5))
            {
                Console.WriteLine(countries[5]);
            }

            if (countries.TryGetValue(5, out string value))
            {
                Console.WriteLine(value);
            }


            //Update

            countries[2] = "Africa";
            //if key is present update , else append , not in order

            //delete

            countries.Remove(5);

            //dont throw exceptionif not found coz return is a bool

            countries.Clear();

        }
    }
}

//keys must be unique