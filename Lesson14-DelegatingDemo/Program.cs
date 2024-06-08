using System.Runtime.CompilerServices;

namespace Lesson14_DelegatingDemo
{
    internal class Program


    {
        static void Greet(string str)
        {
            Console.WriteLine(str);
        }

        // void GreetingDelegate(string message); //error


        public delegate void GreetingDelegate(string message);

        //this  means it point to a funtion that has a string parameter and void return


        static void Main(string[] args)
        {

            // GreetingDelegate  greetingDelegate = new GreetingDelegate();  //error

            GreetingDelegate greetingDelegate = new GreetingDelegate(Greet);

            //this  means it point to a funtion that has a string parameter and void return

            //invoking delegate

            //greetingDelegate(); //no argument error
            greetingDelegate("Delegate is ok");







        }
        

        






    }
}


/*
 
-- Notes
1.Type safe function pointer
2.passing function as a parameter
3.no pointer in c#
4.delegate means handover or pass
5.function signature is important
6.non static can be used


 */