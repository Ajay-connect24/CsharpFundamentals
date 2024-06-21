namespace Lesson15_FinallyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            try
            {

                streamReader = new StreamReader(@"C:\Log.txt");
                Console.WriteLine("Enter the first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber / secondNumber;
                Console.WriteLine(result);



            }
            
            catch (Exception e)

            {
               
                Console.WriteLine(e.Message);

            }

            finally 
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}

//debugging wont go to finally when theres an exception
