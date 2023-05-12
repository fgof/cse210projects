using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Alma", "37", "6", "7");
        Scripture scripture = new Scripture(reference, "Now ye may suppose that this is a foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by ameans to bring about his great and eternal purposes; and by very small means the Lord doth cconfound the wise and bringeth about the salvation of many souls.");
        string userInput = "";

        
        while (userInput != "quit" && scripture.HasWordsLeft() == true )
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
        Console.WriteLine("Thank you for practicing your scripture Mastery!");
    
    
    }
}