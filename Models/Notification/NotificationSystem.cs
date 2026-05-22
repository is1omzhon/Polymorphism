namespace Models.Notification.NotificationSystem;

class Notification
{
    public virtual void Send()
    {
        Console.WriteLine("Sended notification!!!");
    }
}

class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sended Email Notification!!!");
    }
}

class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sended Sms Notification!!!");
    }
}

class TelegramNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sended Telegram Notification!!!");
    }
}