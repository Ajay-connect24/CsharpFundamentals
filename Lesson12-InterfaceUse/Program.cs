﻿using System.Security.Cryptography;

namespace Lesson12_InterfaceUse
{
    public class Program
    {
        static void Main(string[] args)
        {

            ILogging logging = new Sqllogging();

            Customer customer   = new Customer(logging );
            customer.Name = "ajay";
            customer.Id = 1;

            customer.LogMessage();
        }
    }
}
/*
 1.any class that implements ilogging can be passed
private camel case
class, interface pascal
class public prop in pascal
 */