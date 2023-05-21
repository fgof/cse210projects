using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        List<string> menu = new List<string>
        {
            "Menu Options:",
            " 1. Start Breathing activity",
            " 2. Start Reflecting activity",
            " 3. Start Listing activity",
            " 4. Quit"
        };
        while (userChoice != 4)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity ba = new BreathingActivity();
                ba.DoBreathingActivity();
                break;
            }
            if (userChoice == 2)
            {
                ReflectActivity ra = new ReflectActivity();
                ra.DoRefelctionActivity();
                break;
            }
            if (userChoice == 3)
            {
                ListActivity la = new ListActivity();
                la.DoListActivity();
                break;
            }
            if (userChoice == 4)
            {
                break;
            }
        }

    }
}