namespace Lesson21_AgainDelegates

{

    public delegate void PrintDelegate(int number);
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    PrintDelegate printDelegate= new PrintDelegate(Print);
        //    printDelegate(10);
        //}

        //static void Print(int number)
        //{
        //    Console.WriteLine($"Number is{number}");
        //}

        //use of ananoymous functions with delegate keyword
        //-------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    PrintDelegate printDelegate = delegate (int number)
        //    {
        //        Console.WriteLine($"Number is{number}");
        //    };           
        //    printDelegate(10);
        //}

        //---------------------------------------------------------------------

        //delegate inside a  function
        static void Print(PrintDelegate printDelegate , int value)
        {
            value += 10;
            printDelegate(value);
        }

        static void Main(string[] args)
        {
            Print(
                delegate (int value) { Console.WriteLine(value); },
                10
                );
            
            
        }




    }

}

/*
1.anonymous methods are possible in c#
2.reuse code and modularity 
3.if tgere is a special requirment then we use delegates
4.we also have anonymous types
5.

 
 */
