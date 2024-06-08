namespace Lesson13_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printer printer = new Printer();  //abstract class cant create obj

            Customer customer = new Customer();

            customer.Paper(); //make protection level to public  //void Paper() { }
        }
    }

    abstract class Printer
    {
        //void Print(); // must declare a body at least like void Print(){}
        //void Paper() { }
        public void Paper() { }
        //abstract void Print2(); //method cant be private
        public abstract void Print();



    }

    //interface IPrinter : Printer { } //not possible and no use

    interface IPrinter {

        // public string Color; //cant contain instance fields
        public string Color { get; set; }

        public abstract  string Color1 { get; set; } //possible


    }

    //static class HpPrinter : IPrinter { } //static cant implement interface
    

    class Customer : Printer
    {
        //implementing abstract method is kind of overriding

        public string Color { get; set; } //property have getter or setter
        public string Color1; //instance fields possible
        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}


/*
 
1.use abstract keyword - for abstraction
2.obj cannod be made for abstract classes
3.its also like contract like interface
4.obj cant be created coz it has unimplemented methods
5.abstract members cant be private
6.implementing abstract method is kind of overriding
7.abstract class can also have method with body
8.all abstract class are overridden 
9.static in interface is confusing....
10.
 
 */