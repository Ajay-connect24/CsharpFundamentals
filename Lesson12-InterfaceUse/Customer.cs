using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_InterfaceUse
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ILogging _logging;

        public Customer (ILogging logging)
        {

            _logging = logging;
        }

        public void LogMessage()
        {
            _logging.Log($"id : {Id} , name : {Name}");


        }
    }
}


/*
 
private camel case
class, interface pascal
class public prop in public
 */