namespace Lesson15_Returning_delegates
{
    internal class Program
    {
        public delegate int NumberDelegate();
        static void Main(string[] args)
        {
            //NumberDelegate numberDelegate = new NumberDelegate(GetFirstNumber);

            //int result = numberDelegate();
            //Console.WriteLine(result);

            //result = GetSecondNumber();

            //Console.WriteLine(result);

            NumberDelegate numberDelegate = new NumberDelegate(GetFirstNumber);
            
            numberDelegate += GetSecondNumber;  //not GetSecondNumber()  eyes on ()
            int result = numberDelegate();
            Console.WriteLine(result);

            



        }

        static int GetFirstNumber()
        {
            return 1;
        }

        static int GetSecondNumber()
        {
            return 2;
        }
    }
}
