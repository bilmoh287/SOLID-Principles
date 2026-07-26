public class LoggingService
{
    public enum enLoggingType { LogToEventLog, LogToDB, LogToFile }

    public void Log(string message, enLoggingType LogType)
    {

        if (LogType == enLoggingType.LogToEventLog)
        {
            LogToEventLog.LogtoEventLog(message);
        }
        else if (LogType == enLoggingType.LogToFile)
        {
            LogToEventLog.LogtoEventLog(message);
        }
        else if (LogType == enLoggingType.LogToDB)
        {
            LogToDB.LogtoDB(message);
        }
    }

}

public class LogToEventLog
{
    public static void LogtoEventLog(string message)
    {
        Console.WriteLine($"\nLog To File {message}");
    }
}

public class LogToFile
{
    // Method to send SMS
    public static void LogtoFile(string message)
    {
        Console.WriteLine($"\nLog to File {message}");
    }
}

public class LogToDB
{
    // Method to send Fax
    public static void LogtoDB(string message)
    {
        Console.WriteLine($"\nLog to DB {message}");
    }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Log
        LoggingService LoggingService = new LoggingService();

        LoggingService.Log("Logging using EventLog", LoggingService.enLoggingType.LogToEventLog);

        LoggingService.Log("Logging using File", LoggingService.enLoggingType.LogToFile);

        LoggingService.Log("Logging using DB", LoggingService.enLoggingType.LogToDB);

        Console.ReadKey();

    }
}