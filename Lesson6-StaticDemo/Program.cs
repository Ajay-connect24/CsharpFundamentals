namespace Lesson6_StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5);
            firstCircle.CalculateArea();

            Circle secondCircle = new Circle(6);
            secondCircle.CalculateArea();
            
        }
    }
}

/*

---Discussion
1.static variables
2.this usage of static variable => no need of this in static variable
3.staic constructors
4.instance member and class member
5.static constructors used to create static members
6.access modifiers are not allowed on static constructors and are parameterless coz 
7.static ctor are initiallised first , then instance ctor
8.static ctor are only initialised only once even if there are n objects or instances
9.even if variables are part of class and not static ctor then during runtime it scans class and initialises the static variable
10.static constructor runs even if there is no obj  ; if we use ClassName.Variacle name then static ctor works
11.comments // /// /*
12.multiple cursor ctrl+alt+click
13.
 
 */
