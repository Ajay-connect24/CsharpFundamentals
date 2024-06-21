namespace Lesson4_Method_ReferencevalueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 10;
            Print(ref firstnumber);
            Console.WriteLine(firstnumber);


            int total = 0;
            int multipiedOut = 0;

            Calculate(5, 5, out total, out multipiedOut);

            // Calculate(5, 5, out int total, out int multipiedOut);   new way from .net 7

            Console.WriteLine($" Total : {total}\n Multiplied out :{multipiedOut}");



        }

        static void Print(ref int number)
        {
            number = 20;
        
        }

        static void Calculate(int firstNumber, int secondNumber,out int sum ,out int product) 
        {
            sum = firstNumber + secondNumber;
            product = firstNumber * secondNumber;
        
        }
    }
}

/*
 
---Discussion
1.pass by value
2.pass by reference
3.out parameter for multiple outs
4.ref is used to pass and process
5.ref and out are not actually preffered and there are other ways
6.not good coz : value can be accessed and error can happen
7.ref must br initiallised in compile time and not in case for out
8.out must be assigned before leaving the control of method
9.Parse and TryParse
10.
 
 
 
 
 
 
 
 
 
 
 
 
 
 
*/
