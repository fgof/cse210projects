using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer
        ("Me", new Address( "0001 My House", "My Street", "My State", "USA"));

        List<Product> list = new List<Product>();
        list.Add(new Product(1209, "Green Maxi Dress L", 57, 1 ));
        list.Add(new Product(1349, "Sandals", 22, 2));
        list.Add(new Product(3192, "Beige Crochet Tote", 44, 1));
        
        Order o1 = new Order(c1, list);

        Customer c2 = new Customer
        ("You", new Address("0001 Your House", "Your City", "Your State", "South Korea"));
        List<Product> list2 = new List<Product>();
        list2.Add(new Product(6981, "Playstation 5", 500, 1));
        list2.Add(new Product(0400, "PS5 Contoller", 75, 2));

        Order o2 = new Order(c2, list2);

        Console.WriteLine(o1.GetShipingLabel());
        Console.WriteLine($"List of Items: \n{o1.GetPackingLabel()}");
        Console.WriteLine($"Total: {o1.GetPriceTotal()}");
        Console.WriteLine();
        Console.WriteLine(o2.GetShipingLabel());
        Console.WriteLine($"List of Items: \n{o2.GetPackingLabel()}");
        Console.WriteLine($"Total: {o2.GetPriceTotal()}");

    }
}