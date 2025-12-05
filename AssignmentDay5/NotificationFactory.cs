using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{

    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
        }
    }

   
    public  class NotificationFactory
    {
        public static INotification GetNotification(string type)
        {
           
           if (type == "email") {
                return new EmailNotification();
            }
            if (type == "sms")
            {
                return new SmsNotification();
            }
            else
            {
                return new PushNotification();
            }
           
        }
    }

    

}
