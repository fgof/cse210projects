using System;
class ListActivity : Activity
{
    List<string>_prompts = new List<string>();
    List<string>_answers = new List<string>();
    
    public ListActivity()
    {
        SetActivityName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    
    }
    public void DoListActivity()
    {
        Animation a = new Animation();
        WelcomeMessage();
        Console.WriteLine("Get ready...");
        a.InitialCountDown();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        Console.WriteLine("List as many responses as to can to the following prompt:");
        Console.WriteLine();

        Random random = new Random();

        Console.WriteLine($"  ---- {_prompts[random.Next(0, _prompts.Count-1)]} ----  ");
        Console.WriteLine();
        Console.WriteLine("You may begin in...");
        a.InitialCountDown();
        int i = 1;
        while (start < end)
        {
            Console.Write($"{i}-> ");
            _answers.Add(Console.ReadLine());
            start = DateTime.Now;
            i++;
        }
        Console.WriteLine($"You listed {_answers.Count()} items.");
        _answers = new List<string>();
        ByeMessage();

    }
}
