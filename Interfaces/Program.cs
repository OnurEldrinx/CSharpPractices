using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            DatabaseLogger databaseLogger = new DatabaseLogger();
            FileLogger fileLogger = new FileLogger();
            SmsLogger smsLogger = new SmsLogger();

            databaseLogger.writeLog();
            fileLogger.writeLog();
            smsLogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            
            logManager.writeLog();

        }
    }
}
