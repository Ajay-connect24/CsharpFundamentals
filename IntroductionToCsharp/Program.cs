using System;

namespace IntroductionToCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string name =Console.ReadLine();
            //Console.WriteLine(name);


            string firstname = "Jhon";
            string lastname = "Doe";

            Console.WriteLine("Welcome "+firstname +" "+ lastname);
            Console.WriteLine($"Welcome {firstname} {lastname}");
            Console.WriteLine( "Welcome {0} {1}",firstname,lastname);

            Console.WriteLine("\" James\"");

            int size =sizeof(int);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            //int count1 = null;   //   error
            int? count2 = null;    //no error
            string name1 = null;   //no error



        }
    }
}



/*
---DISCUSSION

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>


1.Multiple projects can be created frm solution explorer..using add option
2.Disabling implicit using ....using system namespace - console class for using methode writeLine
3.Go to defenition of console
4.ctrl + f5 to run or dotnet run
5.take input frm user using ReadLine()
6.String formating
7.Escape sequences
8.sizeof()
9.Minvalue and maxvalue
10.DataTypes : reference types and value types...all ref types can point to null value ie interfaces, classes
11.ref stored in heap...value types in stack
12.passing null values
13.Disabling nullable


 
 
 */
