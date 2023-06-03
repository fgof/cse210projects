using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-|          Reception          |-\n");
        Reception r = new Reception
        ("Gracies 23rd Birthday", "Come celebrate Gracies 23rd SUPRISE birthday. Dont tell her! oh and it is Cartoon themed so come as your favorite cartoon character.", new DateTime(2023,8,18), new TimeSpan(04,00,00), "2310 Reservation rd, Bock Bill, SC, 92746", "bleebloop@gmail.com");
        Console.WriteLine(r.StandardDetails());
        Console.WriteLine("------------------------------");
        Console.WriteLine(r.GetFullDetails());
        Console.WriteLine("------------------------------");
        Console.WriteLine(r.GetShortDescription());

        Console.WriteLine("-|          Lecture          |-\n");
        Lecture l = new Lecture
        ("The Brain", "Hannibal Lecter talks about his specialtiy", new DateTime(2023,7,16), new TimeSpan(10,00,00), "100 Smart Street, Miami, FL, 28003", "Hannibal Lecter", 52);
        Console.WriteLine(l.StandardDetails());
        Console.WriteLine("------------------------------");
        Console.WriteLine(l.GetFullDetails());
        Console.WriteLine("------------------------------");
        Console.WriteLine(l.GetShortDescription());

        Console.WriteLine("-|          Outdoor Reception          |-\n");
        Outdoor o = new Outdoor
        ("Annas BabyShower", "Please join us in prep for Annas new babygirl", new DateTime(2023, 1, 23), new TimeSpan(11,00,00), "1415 Arizona rd, Arizona st, Tuscan, AZ, 00156", "Clear Skies");
        Console.WriteLine(o.StandardDetails());
        Console.WriteLine("------------------------------");
        Console.WriteLine(o.GetFullDetails());
        Console.WriteLine("------------------------------");
        Console.WriteLine(o.GetShortDescription());

        
    }
}