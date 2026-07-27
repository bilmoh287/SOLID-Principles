using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LoggingService
{
    private ILoggingService _LoggingService;
    public LoggingService(ILoggingService loggingService)
    {
        _LoggingService = loggingService;
    }

    public void Log(string message)
    {

        //if (LoggingType == enLoggingType.ToFile)
        //{
        //    FileLoggingService.Log(message);
        //}
        //else if (LoggingType == enLoggingType.ToEventLog)
        //{
        //    EventLogService.Log(message);
        //}
        //else if (LoggingType == enLoggingType.ToDatabase)
        //{
        //    DatabaseLoggingService.Log(message);
        //}

        _LoggingService.Log(message);
    }

}

public interface ILoggingService
{
    void Log(string message);
}

public class FileLoggingService : ILoggingService
{
    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }
}

public class EventLogService : ILoggingService
{
    // Method to log to EventLog
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}

public class DatabaseLoggingService : ILoggingService
{

    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}

public class ExcelLoggingService : ILoggingService
{

    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Excel: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService( new FileLoggingService());

        // Log to File
        LoggingService.Log("Error Occured line xxx.");

        LoggingService = new LoggingService(new EventLogService());
        // Log to Event Log
        LoggingService.Log("Error Occured line xxx.");

        LoggingService = new LoggingService(new DatabaseLoggingService());
        // Log to Database
        LoggingService.Log("Error Occured line xxx.");

        LoggingService = new LoggingService(new ExcelLoggingService());
        // Log to Database
        LoggingService.Log("Error Occured line xxx.");

        Console.ReadKey();

    }
}

