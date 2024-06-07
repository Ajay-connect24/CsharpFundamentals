using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_InterfaceUse
{
    public interface ILogging
    {
        void Log(string message);
    }

    public class Filelogging : ILogging
    {

        public void Log(string message)
        {
            Console.WriteLine($"File Logging :{message}");
        }
    }

    public class Consolelogging : ILogging
    {

        public void Log(string message)
        {
            Console.WriteLine($"Console Logging :{message}");
        }
    }

    public class Sqllogging : ILogging
    {

        public void Log(string message)
        {
            Console.WriteLine($"SqlLogging :{message}");
        }
    }
}
