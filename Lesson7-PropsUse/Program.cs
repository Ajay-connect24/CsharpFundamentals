using System.ComponentModel.DataAnnotations;

namespace Lesson7_PropsUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            Console.WriteLine(student.Id);

            var x = 10;
            var y = "hello";

            Display("Ajay");
            Display();
            Display2(10);
            Display2(10,num1:15);

        }

        public static void Display(string name =" john") { Console.WriteLine($"Hello {name}"); }

        public static void Display2 (int y , string name= "Thomas" ,int num1=10 , int num2=20)
        {
            Console.WriteLine($"Hello y : {y} name : {name} num1 :{num1} num2 :{num2}");

        }
    }
}

/*
---Notes
1.use of var
2.cant use var inside method parameter since var value should always be initiallised
3.optional parameters like params need to be at last
4.can be passed at random but variable name should be used in parameter if not passed fully //like in dart patameter1:  parameter 2:
5.optional parameter should be after all req param




*/
