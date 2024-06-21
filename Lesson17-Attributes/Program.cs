using System.Reflection.Metadata;

namespace Lesson17_Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(1,2);
            Calculator.Add(1, 2, 3);
        }
    }

    class Calculator
    {
//        [Obsolete]  //obseleteAttributr and obselete are same
        [Obsolete("use the one with params")]
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(params int[] x)
        {
            int sum = 0;

            foreach (int i in x)
            {
                sum += i;
            }
            return sum; 
        }

    }
}
