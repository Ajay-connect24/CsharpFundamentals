using System.Numerics;

namespace Lesson20_GenericsWhereClause
{
    class Utiity<T> where T : struct //insteead of struct we use some interfaces
    {
        public void Add(T firstNumber, T secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber); // errro coz we cant add two classes...for these senarios we have where clause
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

            Utiity<string>.AreEqual("aa", "abc"); // coz string is not a struct
            Utiity<int>.AreEqual(0,1);

        }
    }
}
