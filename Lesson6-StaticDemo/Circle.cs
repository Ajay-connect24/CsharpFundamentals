using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_StaticDemo
{
    internal class Circle
    {
        int _radius ;
        //float _pi = 3.14F; 
        //static float _pi = 3.14F;
        static  float _pi ;


        static Circle() // no parameter since we are not supposed to change value
        {               //no access modifier

            _pi = 3.14F;
            Console.WriteLine("i am static ctor");


        }

        public Circle(int radius)
        {
            _radius = radius;
            Console.WriteLine("i am instance ctor");
            
        }

        public void CalculateArea()
        {
            //float area = this._pi * this._radius * this._radius;
            float area = _pi * this._radius * this._radius;
            Console.WriteLine($"Area is {area}");
        }

    }
}
