using System.Security.Cryptography;

namespace Lesson15_Multicast_delegates
{
    internal class Program
    {
        public delegate void MethodDelegate();
        static void Main(string[] args)
        {

            MethodDelegate methodDelegateOne = new MethodDelegate(MethodOne);
            MethodDelegate methodDelegateTwo = new MethodDelegate(MethodTwo);
            MethodDelegate methodDelegateThree = new MethodDelegate(MethodThree);

            //methodDelegateOne.Invoke();
            //methodDelegateOne.Invoke();

            //methodDelegateOne();
            //methodDelegateTwo();
            //methodDelegateThree();

            //MethodDelegate methodDelegatefour = methodDelegateOne + methodDelegateTwo + methodDelegateThree;
            //methodDelegatefour();

            MethodDelegate methodDelegate = new MethodDelegate(MethodOne);
            methodDelegate += MethodTwo;
            methodDelegate += MethodThree;
            methodDelegate -= MethodOne;

            methodDelegate();

            


        }

        static void MethodOne() {
            Console.WriteLine("Method One");
        }
        static void MethodTwo()
        {
            Console.WriteLine("Method two");
        }
        static void MethodThree()
        {
            Console.WriteLine("Method three");
        }
    }

}


/*
 --Notes
1.chaining delegates
2.
 
 
 
 */