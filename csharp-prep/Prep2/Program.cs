using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your total grade?");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        } 
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}");
        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("You idiot, you failed!");
        }
    
    }
}