namespace Lesson21_DelegatesFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addDelegate = Add;
            //last in func is retuen type , then name of delegate and the normal func name we pass

            Func<int> testDelegate = Test;

            //no matter what the last one will be the output--the remaining will be dinamically created

            Func<int, int, int> addAnonymous = delegate (int fisrtNum, int secondNum)
            {
                return fisrtNum + secondNum;
            };
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Test() 
        { 
            return 1;
        }


    }
}

/*
1.no need to create delegate and an obj of delegate 
 */
