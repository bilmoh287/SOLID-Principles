using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NotificationService
{
    private INotification _Notification;
    public NotificationService(INotification notification)
    {
        _Notification = notification;
    }
    public void SendNotification(string to, string message)
    {

        //if (NotificationType == enNotificationType.Email)
        //{
        //    EmailService.SendEmail(to, message);
        //}
        //else if (NotificationType == enNotificationType.SMS)
        //{
        //    SMSService.SendSMS(to, message);
        //}
        //else if (NotificationType == enNotificationType.Fax)
        //{
        //    FaxService.SendFax(to, message);
        //}

        _Notification.Send(to, message);
    }

}
public interface INotification
{
    public void Send(string to, string message);
}

public class EmailService : INotification
{
    // Method to send email
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }
}

public class SMSService : INotification
{
    // Method to send SMS
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }
}

public class FaxService : INotification
{
    // Method to send Fax
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}
public class TelegramService : INotification
{
    // Method to send Fax
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Telegram to {to}: {message}");
    }
}

public class WhatsappService : INotification
{
    // Method to send Fax
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Whatsapp to {to}: {message}");
    }
}


class Program
{
    static void Main()
    {
        // Create an instance of the NotificationService
        NotificationService notificationService = new NotificationService(new EmailService());

        // Send an email
        notificationService.SendNotification("john@example.com", "Welcome to our service!");

        notificationService = new NotificationService(new SMSService());

        // Send an SMS
        notificationService.SendNotification("+123456789", "Your OTP code is 1234.");

        notificationService = new NotificationService(new FaxService());
        // Send a fax
        notificationService.SendNotification("123-456-789", "Fax Message: Important document.");

        notificationService = new NotificationService(new WhatsappService());
        // Send a Whatsapp
        notificationService.SendNotification("Mr Bilal", "whatsapp Message: Important document.");

        notificationService = new NotificationService(new TelegramService());
        // Send a Telegram
        notificationService.SendNotification("Mr Harun", "Hello Sir it's done!");

        Console.ReadKey();

    }
}



