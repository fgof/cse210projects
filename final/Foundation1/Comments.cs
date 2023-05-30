using System;
public class Comments
{
    public string _user;
    public string _comment;
    public void DisplayComment()
    {
        Console.WriteLine($"{_user} '{_comment}'");
    }
}