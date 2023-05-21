using System;
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void DoBreathingActivity()
    {
        Animation a = new Animation();
        WelcomeMessage();
        Console.WriteLine("Get ready...");
        a.InitialCountDown();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());
        while (start < end)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            a.CountDown(5);
            Console.WriteLine("Breathe out...");
            a.CountDown(4);
            start = DateTime.Now;
        }
        ByeMessage();
    }







}