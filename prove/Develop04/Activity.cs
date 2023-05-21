using System;

class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;


    public Activity()
    {

    }

    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long will your session be? (In seconds)");
        SetDuration(int.Parse(Console.ReadLine()));
    }
    public void ByeMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job");
        Console.WriteLine($"You did {_duration} seconds of the {_activityName} activity.");
        Console.ReadLine();
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    protected int GetDuration()
    {
        return _duration;
    }











}