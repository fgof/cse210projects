using System;

public class Journal
{

    List<Entry> entries;

   public Journal()
   {
        entries = new List<Entry>();
   }

   public void DisplayJournalEntries()
   {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        } 

   }

   public void CreateJournalEntry()
   {
        DateTime theCurrentTime = DateTime.Now;

        string date = theCurrentTime.ToShortDateString(); 
        
        PromptGenerator prompt1 = new PromptGenerator();
        string prompt = prompt1.GetRandomPrompt();
        Console.WriteLine($"{prompt}");

        Console.WriteLine(">");
        string response = Console.ReadLine(); 

        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);

    //get a random prompt and response
    //create entry object and add to entries list
   }
   public void SaveToCSV()
   {
        string file = "SavetoCSV.cs";
        List<string> records = new List<string>();
        foreach(Entry entry in entries)
        {
            records.Add(entry.getEntryAsCSV());
        }
        File.WriteAllLines(file, records);


   }
   public void LoadFromCSV()
   {

   }
}
 