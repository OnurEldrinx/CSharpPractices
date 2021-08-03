using System;

namespace Interfaces
{

    public class SmsLogger : Logger
    {
        public void writeLog()
        {
            Console.WriteLine("The log is written and sent by SMS.");
        }
    }

}