using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Class
{
    internal class Customer
    {
        string _firstname;
        string _lastname;

        public Customer() : this("NO FN", "NO LN")
        { 
        
        }
        public Customer(string firstname,string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        public void PrintFullname()
        {
            Console.WriteLine($"Fullname = {_firstname} {_lastname}");

        }
    }
}
