using System;

class Program
{
    static void Main(string[] args)
    {
        Journal   journal = new Journal();
        int       menuUserinput = 0;

        List<string> menu = new List<string>
        {
            "What would you like to do?",
            "1. New entry",
            "2. Display jounal",
            "3. Load journal",
            "4. Save entry",
            "5. Close journal"

        };

    
        while (menuUserinput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());
            
                if (menuUserinput == 1)
                {
                    journal.CreateJournalEntry();

                }
                if (menuUserinput == 2)
                {
                    journal.DisplayJournalEntries();
                }
                if (menuUserinput == 3)
                {
                    journal.SaveToCSV();
                }
                if (menuUserinput == 4)
                {
                    journal.DisplayJournalEntries();
                }
        }
    }
}