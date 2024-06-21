namespace Lesson16_InnerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());

                    if (firstNumber == 0)
                    {
                        throw new Exception("First number cannot be zero");
                    }
                    Console.WriteLine("Enter the second number");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int result = firstNumber / secondNumber;
                    Console.WriteLine(result);


                }

                catch (Exception ex)

                {
                    throw new Exception("User exception ", ex);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Inner Exception :{ex.InnerException.Message}");
                Console.WriteLine(ex.Message);



            }
        }
    }
}
