using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    //ESKİ
    public class Notification
    {
        public void SendNotification(User user)
        {
            Console.WriteLine(user.Name + " için " + user.Email + " eposta adresine notification gönderildi");
        }
    }

    //FACTORY
    //----------------------

    public enum NotificationType
    {
        Email = 0,
        Sms = 1
    }

    public interface INotify
    {
        void SendNotification(User user);
    }

    public class MailNotification : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine(user.Name + " için " + user.Email + " eposta adresine notification gönderildi");
        }
    }

    public class SmsNotification : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine(user.Name + " için " + user.Phone + " telefonuna notification gönderildi");
        }
    }

    public static class NotificationFactory
    {
        public static INotify CreateNotification(NotificationType type)
        {
            if (type == NotificationType.Email)
                return new MailNotification();
            else if (type == NotificationType.Sms)
                return new SmsNotification();

            return null;
        }
    }
}
