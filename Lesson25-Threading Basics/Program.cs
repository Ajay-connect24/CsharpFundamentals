namespace Lesson25_Threading_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.Name);

            int x = 10;
            Thread.Sleep(5000); //In milli sec
            Console.WriteLine(x);

            int y = 20;
            Console.WriteLine(y);
            Thread.CurrentThread.Name = "MyMain Thread";
            Console.WriteLine(Thread.CurrentThread.Name);


            
        }
    }
}
/*
--Notes--
1.Process have process id
2. A process is an instance of a program that is being executed or processed. 
3.Thread is a segment of a process or a lightweight process that is managed by the scheduler independently
4.code is handled by a single thread called main thread
5.debug > windows > threads
6.by default thread dont have name
7. single thread apps ...delay if 1 step is waiting
8.single threads are non responsive ...we need to wait until it ends
9..Multithreading...we can run tasks parallely
10.context switching or time slicing ...just read
11.

 */