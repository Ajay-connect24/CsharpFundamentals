namespace Lesson20_Boxing
{
    
    class Utility
    {
        public static bool AreEqual(object firstnumber, object secondnumber) 
        {
            return firstnumber == secondnumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.AreEqual(1, 2);
        }
    }
}

//boxing means converting value to re type.Value type is faster as it is in stack
