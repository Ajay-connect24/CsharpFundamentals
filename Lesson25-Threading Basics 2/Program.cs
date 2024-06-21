namespace Lesson25_Threading_Basics_2
{
    class Number
    {
        int _result;
        //making type safe 
        public Number(int result) 
        {
            _result = result;
        
        }

        public void Print3()
        {
            
                for (int i = 0; i < _result; i++)
                {
                    Console.WriteLine(i);
                }
            

        }
        public static void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Print2(object target)
        {
            if (int.TryParse(target.ToString(), out int number))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Thread threadOne = new Thread(new ThreadStart(Number.Print));
            threadOne.Start();

            Thread thread = new Thread(Number.Print);
            thread.Start();

            //Thread threadOne = new Thread(() => Number.Print());
            //threadOne.Start();

            //Thread threadOne = new Thread(delegate () { Number.Print(); });
            //threadOne.Start();

            //Thread threadTwo = new Thread(new ParameterizedThreadStart(Number.Print2));  //change print method signature to obj
            //threadTwo.Start(10);

            Number number = new Number(30);
            Thread threadTwo = new Thread(new ThreadStart(number.Print3));  //change print method signature to obj
            threadTwo.Start();

            threadTwo.Join();  //wait main  until  above thread finishes
            //threadTwo.Join(4000);  //wait threadTwo only for 4 sec
            Console.WriteLine("Finished");




        }
    }
}

//method with parameter and without parameter in threads

//parameterizedTHreadSstart delegate is not a type safe function pointer
//every time i need to convert obj type to value type
//it can accept anything and that is an issue
//
