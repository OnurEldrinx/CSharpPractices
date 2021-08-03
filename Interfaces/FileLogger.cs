using System;

namespace Interfaces
{

    public class FileLogger : Logger
    {
        public void writeLog()
        {
            Console.WriteLine("The log is written into the log file.");
        }
    }


}