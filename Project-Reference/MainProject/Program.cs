using CalculatorLibrary;
using System.ComponentModel;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator =new Calculator();
            calculator.Add(5, 5);

            

        }
        class Hello : Calculator 
        {

            public void Print() 
            {
                Calculator calc = new Calculator();
                base.
            }
        }
    }
}
/*
 --NOtes
1.add new solution folder by clicking soln
2.create project eyes on file locatioon
3.virtual hence wont create unless proj added in correct location
4.create new project ass class library
5.add refrence of library on main project
6.using namespace
7.type and type members in c#
8.fields , props , methods are part of type members 2:41:00
9.typemembers :fields, properties, constructors, methods, events, constants, and variables :: types : classes, structs, enums, interfaces, and delegates
10.only 2 acess modif for types ...........internal or public (default is internal)
11.typemembers: methods , fileds, props
12.public , private , internal ,protected , protected internal
13.by default type members are private 
14.internal class can be used in project ......pvt only in that class
15.for protected inheritence is needed
16.pvt cant be acessed by inheritence
17.all the above are at assembly level
18. protected (unless inherited) and pvt wont be acessed ouside the assembly level
19.class is internal by default
20.
 */