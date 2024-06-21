namespace Lesson21_DelegatesActionDlegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //no retun for action 
            Action<int, int> actionDelegates = Add;
            Action displayDelegate = Display;
            //Action<> displayDelegate = Display; error coz <>  not nneeded

            Action<int, int> actionAnonymous = delegate (int firstNumber, int secondNumber) 
            {
                Console.WriteLine(firstNumber+secondNumber);            
            };

            Action<int,int> actionLambda = (firstNumber, secondNumber) => Console.WriteLine(firstNumber + secondNumber);

        }

        static void Add( int firstNumber ,int secondNumber ) => Console.WriteLine(firstNumber + secondNumber);

        static void Display() => Console.WriteLine("this is output");

    }
}
