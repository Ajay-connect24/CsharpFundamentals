using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTips
{
    internal class Test
    {
        void Print() 
        {

            Person person = new Person();
            person.IsPromotable(10);
        }
        


    }

    sealed class Person
    {
        
    }

    static class PersonExtension
    {
        public static bool IsPromotable(this Person person, int age) => age > 18;
    }
}
