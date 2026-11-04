using System;
using System.Collections.Generic;
using System.Linq;

public class NotificationBuilder
{
    private  Func<User, string> _buildMessage = delegate (User user)
    {
        return $"Пользователь {user.Name} зарегистрирован. Email: {user.Email}";
    };

    public List<string> Build(List<User> users)
    {
        return users.Select(_buildMessage).ToList();
    }
}