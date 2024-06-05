using System.ComponentModel.Design;

namespace Lesson2_DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int firstnumber = 10;
            float secondnumber = firstnumber;

            //typecating 

            double thirdnumber = 10;
            //int forthnumber = thirdnumber; //error
            int forthnumber = (int) thirdnumber;

            // using Convert class

            int fifthnumber =Convert.ToInt32(thirdnumber);

            //string to number

            string sixthnumber = "50";
            int seventhnumber = Convert.ToInt32(sixthnumber);

            //if string input is null then int value assigned is 0

            string eighthnumber = null;
            // string num = "" or "abc" throws exception
             int ninethnumber = Convert.ToInt32(eighthnumber);
            Console.WriteLine(ninethnumber);

            //rounding off

            double a = 10.60;
            int b = Convert.ToInt32(a);
            int c = (int)a;

            Console.WriteLine($" b = {b} \n c = {c}");


            // int to byte 

            int number = 500;
            //byte bytenumber1 = Convert.ToByte(number); // throws overflow exception
            byte bytenumber2 = (byte)number;
            //Console.WriteLine($" bytenumber1 : {bytenumber1} \n bytenumber2 : {bytenumber2} ");

            // byte value 0-255...out is 244 ans => 500/256


            //using Parse

            string input = "1234";//1234abc
            int num = int.Parse(input);
            Console.WriteLine(num); // 1234abc throws exception but 1234 is possible

            bool canBeParsed = int.TryParse(input , out int result);

            if (canBeParsed)
            { 
                Console.WriteLine($"Value = {result}"); 
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine($"Value = {result}");
            }




            }
    }
}

/*
 

---DISCUSSION
1.open solution file frm file explorer ,open proj or soln 
2.install c#devkit in vs code
3.changing startup project in Solution explorer >> Set as startup project
4.two types and data conv: implicit and explicit
5.implict auto conv ...smaller to larger type
6.typecasting
7.Convert class
8.String to number using Conver class
9.null string
10.roundoff
11.byte overflow
12.copilot can explain code
13.parse int
14.tryParse
 
 
*/
