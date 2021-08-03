using System;

namespace Interfaces
{

    public class DatabaseLogger : Logger
    {
        public void writeLog()
        {
            Console.WriteLine("The log is written into the database.");
        }
        
    }


}