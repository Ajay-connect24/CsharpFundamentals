using System.Numerics;

namespace Lesson20_UtilityGeneric
{

    class Utiity
    {
        
        public static bool  AreEqual<T>(T firstNumber, T secondNumber) //made type safe by <T>
        {
            return firstNumber.Equals(secondNumber); //can be used as its in object class
        }
        //public static bool AreEqual<T>(T firstNumber, T secondNumber) 
        //{
        //    return firstNumber == secondNumber;
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Utiity.AreEqual<int>(1, 5); //<> both parameter will be the one in <>
        }
    }
}

/*
--NOtes
1.making type safe using generics
2.type safe emthods ate strongly tied
 */