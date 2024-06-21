using static System.Net.Mime.MediaTypeNames;

namespace Lesson21_Delegate_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Func<int, int, int> addAnonymous = delegate (int fisrtNum, int secondNum)
            {
                return fisrtNum + secondNum;
            };


            Func<int,int,int> addLambda = (int firstNumber ,int secondNumber) => firstNumber + secondNumber;

            Func<int, int, int> addLambdaWithoutDataType = (firstNumber, secondNumber) => firstNumber + secondNumber; //no need of return with =>

            Func<int, int, int> addLambdaWithReturn = (firstNumber, secondNumber)=> //dont miss this => here 
            {
                firstNumber += 10;
                return firstNumber + secondNumber;
                //if multiline use return
            
            };
        }
    }
}
