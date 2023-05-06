using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFraction());
        Console.WriteLine(f.DecimalAmount());

        Fraction f1 = new Fraction(5);
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.DecimalAmount());

        Fraction f2 = new Fraction(3, 4);
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.DecimalAmount());

        Fraction f3 = new Fraction(1, 3);
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.DecimalAmount());
    }
}