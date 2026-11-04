using System;
using System.Collections.Generic;

public class UserFilter
{
    private  Predicate<User> _isAdult = delegate (User user)
    {
        return user.Age > 18;
    };

    private  Predicate<User> _nameStartsWithA = delegate (User user)
    {
        return user.Name.StartsWith("A");
    };

    public List<User> GetAdults(List<User> users)
    {
        return users.FindAll(_isAdult);
    }

    public List<User> GetNamesStartingWithA(List<User> users)
    {
        return users.FindAll(_nameStartsWithA);
    }
}