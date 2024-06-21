using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_CustomExceptions
{
    public  class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message) : base(message) //we use message in base class and give it to user
        {
           // Message = "message";
           //message camt be assigned like this...its read only
        }
    }
}

//we can use ex.message