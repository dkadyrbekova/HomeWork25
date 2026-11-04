using System;
using System.Collections.Generic;

public class NotificationSender
{
    private  Action<string> _send = delegate (string message)
    {
        Console.WriteLine("[notification] " + message);
    };

    public void SendAll(List<string> messages)
    {
        messages.ForEach(_send);
    }
}