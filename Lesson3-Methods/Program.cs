namespace Lesson3_Methods
{
    internal class Program
    {
        //// using static method
        //static void main(string[] args)
        //{
        //    printhelloworld(); // program.printhelloworld()  also works
        //}

        //public static void printhelloworld()
        //{
        //    Console.WriteLine("hello, world!");
        //}



        ////using nonstatic method

        //static void Main(string[] args)
        //{
        //    Program program = new Program();
        //    program.PrintHelloWorld(); 
        //}

        //public  void PrintHelloWorld()
        //{
        //    Console.WriteLine("Hello, World!");
        //}



        static void Main(string[] args)
        {
            printhelloworld(); // program.printhelloworld()  also works
            PrintSum(new int[] {1,2,3,4,5});
            paramsPrintSum(5,new int[] {1,2,3,5});
            paramsPrintSum(1, 2, 3, 4, 5);

            PrintSum([1, 2, 3, 4, 5]);
        }

        public static void printhelloworld()
        {
            Console.WriteLine("hello, world!");
        }

        public static void PrintSum(int[] numbers) 
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine($"Sum is {sum}");

            
        }

        //params should be last
        //normal array passing also works for params
        /*
            PrintSum(new int[] {1,2,3,4,5});
            paramsPrintSum(5,new int[] {1,2,3,5});
            paramsPrintSum(1, 2, 3, 4, 5); 
        */
        public static void paramsPrintSum(int x,params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine($"Sum is {sum}");


        }





    }
}

/*
---Discussion
1.reusable block of statements
2.static and non static
3.static needs no object ; non static needs
4.passing  arguments
5.params keyword
6.collection expression in dotnet 8 => PrintSum([1,2,3,4,5]); instead of PrintSum(new int[] {1,2,3,4,5});

*/