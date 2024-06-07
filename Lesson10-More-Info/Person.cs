using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_More_Info
{
    public struct Person
    //public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public int Id;
        //public string Name;

        //public Person(int id, string name)
        //{
        //    this.Id = id;
        //    this.Name = name;

        //}
        public void Print()
        {
            Console.WriteLine($"Name: {Name} id : {Id}");
        }

        




    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // public required string Name { get; set; }


        public override string ToString()
        {
            return $"Name : {Name} Id:{Id} ";
        }

        //Person person = new Person(1, "Thomas");

    }
}
