namespace Lesson16_FinallyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber / secondNumber;
                Console.WriteLine(result);


            }

            catch (Exception e)

            {
                throw new Exception();

            }

            finally
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}


/*

--Notes
1.when debugging finally wont be executed..coz it stops at exception
2.even when exception hits finally works
3.also works without exception
4.usaually used to free acessed resources
5.use finally to give meaningful message to end user
 */