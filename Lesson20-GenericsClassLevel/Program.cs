namespace Lesson20_GenericsClassLevel
{
    class Utiity<T>
    {
        public void Add(T firstNumber ,T secondNumber)
        {
            Console.WriteLine(firstNumber +  secondNumber); // errro coz we cant add two classes...for these senarios we have where clause
        }
        public static bool AreEqual(T firstNumber, T secondNumber) 
        {
            return firstNumber.Equals(secondNumber);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Utiity<int>.AreEqual(1, 5); //<> both parameter will be the one in <>
        }
    }
}
