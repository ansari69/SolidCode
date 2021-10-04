using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseManager smsNotification = new DatabaseManager(new SMSNotification());

            DatabaseManager emailNotification = new DatabaseManager(new EmailNotification());


            smsNotification.Add();
            emailNotification.Add();

            Console.ReadKey();
          //  Console.WriteLine(smsNotification.Add());
        }
    }


    public interface INotification
    {
        void Send(string message);
    }


    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            // send email
            Console.WriteLine("send email");
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            // send sms
            Console.WriteLine("send sms");
        }
    }



    public class DatabaseManager
    {
        private INotification notification;

        public DatabaseManager(INotification notification)
        {
            this.notification = notification;
        }

        public void Add()
        {
            notification.Send("Record added to database!");
        }

        public void Remove()
        {
            notification.Send("Record removed to database!");
        }

        public void Persisit()
        {
            notification.Send("Changes submitted to database!");
        }
    }



}
