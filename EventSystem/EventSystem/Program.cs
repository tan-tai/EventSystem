using System;

delegate void MessageHandler(string message);

class NotificationCenter
{
    public event MessageHandler MessageReceived;

    public void SendMessage(string message)
    {
        Console.WriteLine("Sending message: " + message);

        if (MessageReceived != null)
        {
            MessageReceived(message);
        }
    }
}

class Program
{
    static void Main()
    {
        NotificationCenter notifier = new NotificationCenter();

        notifier.MessageReceived += DisplayMessage;

        notifier.SendMessage("Hello, My name is Enzo!");

        notifier.MessageReceived -= DisplayMessage;

        notifier.SendMessage("No one is listening!");

        Console.ReadLine();
    }
    static void DisplayMessage(string message)
    {
        Console.WriteLine("Received message: " + message);
    }
}

