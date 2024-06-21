namespace Lesson21_DelegatePredecate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = IsValid;
            //always return bool , only inputs are in angle brackets
            // similar to 
            Func<int,bool> func = IsValid;

            Predicate<int> preed = isTrue;

            Func<bool> function = isFalse;
        }

        static bool IsValid(int age)
        {
            return age > 0;
        }

        static bool isTrue(int num) 
        {
            return true;
        
        }

        static bool isFalse()
        {
            return false;

        }
    }
}
