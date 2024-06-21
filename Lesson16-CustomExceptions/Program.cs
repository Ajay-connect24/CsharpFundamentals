namespace Lesson16_CustomExceptions
{
    internal class Program
    {


        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("First number cannot be zero");
            }
            catch (Exception ex) 
            { 
               // Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }
        }
    }
}
