namespace Lesson16_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber / secondNumber;
                Console.WriteLine(result);


            }
            catch (FormatException e)
            {
                //Console.WriteLine(e.Message);//GETS MESSAGE DESCRIBING CURRENT EXCEPTION
                //Console.WriteLine(e.StackTrace);
                //Console.WriteLine("Number tooo big");

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);//GETS MESSAGE DESCRIBING CURRENT EXCEPTION

            }
            catch (Exception e)

            {
                Logging.LogErros(e.StackTrace);
                Console.WriteLine(e.Message);//gets message describing current exception

            }
            //catch 
            //{
            //    Console.WriteLine("Something went wrong");

            //}
        }

        class Logging
        {
            public static void LogErros(string message)
            {

                //logic to push erros to server 
            }
        }
    }
}

/*

--Notes
1.we can give message for particular exceptions
2.finally used to close resources
3.log errors and crash in different server

*/
