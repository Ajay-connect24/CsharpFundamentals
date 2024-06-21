using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalculatorLibrary
{
    public class Calculator //use internal
    {
        public  int Add(int firstNumber1, int secondNumber)
        {
            return firstNumber1 + secondNumber;
        }

        int Subtract(int firstNumber1, int secondNumber) { return firstNumber1 - secondNumber; }

        protected int Multiply(int firstNumber1, int secondNumber) { return (firstNumber1 * secondNumber); }

    }

    public class TestClass : Calculator {
        
        public void Print()
        {
            Calculator calc = new Calculator();
            base.Multiply(5, 5);
            

            this.Multiply(5, 5);

        }

       


        
    }
}
