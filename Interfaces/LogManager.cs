using System;

namespace Interfaces
{

    public class LogManager:Logger
    {

        public Logger myLogger;

        public LogManager(Logger logger)
        {
            this.myLogger = logger;
        }

        public void writeLog()
        {
            myLogger.writeLog();
        }
    }

}