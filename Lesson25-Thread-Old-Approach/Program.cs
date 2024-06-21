namespace Lesson25_Thread_Old_Approach
{
    internal class Program
    {
        delegate void SumDelegate(int sum);
        class Number
        {
            int _target;
            SumDelegate _sumDelegate;
            //Action<int> _sumDelegate;

            //public Number(int target, Action<int> sumDelegate)
            public Number(int target, SumDelegate sumDelegate)
            {
                _target = target;
                _sumDelegate = sumDelegate;
            }

            public void GetSum()
            {
                int sum = 0;
                for (int i = 0; i < _target; i++)
                {
                    sum += i;
                }
                _sumDelegate(sum);
            }
        }
        static void Main(string[] args)
        {

            Number number = new Number(30, PrintSum);

            Thread thread = new Thread(number.GetSum);
            thread.Start();
            thread.Join();
            Console.WriteLine("Finished");

        }

        static void PrintSum(int sum)
        {
            Console.WriteLine("The sum = " + sum);
        }
    }
}
