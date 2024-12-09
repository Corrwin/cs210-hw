using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1234 Old Man Lane", "Laketown", "Ohio", "USA");
        Customer c1 = new Customer(a1, "John Doe");
        Console.WriteLine(c1.InUSA());
        Console.WriteLine(a1.FullAddress());

        Product p1 = new Product("Cheap button", 1023, 2, 5);
        Product p2 = new Product("Keyboard", 1843, 34, 1);

        Product p3 = new Product("chessboard", 1245, 34, 3);
        Product p4 = new Product("backgammon", 8794, 22, 2);
        Product p5 = new Product("blanket", 4423, 57, 1);

        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Address a2 = new Address("364 S Greek Lane", "Homerville", "Dublin", "Ireland");
        Customer c2 = new Customer(a2, "RTGame");
        Order o2 = new Order(c2);
        o2.AddProduct(p3);
        o2.AddProduct(p4);
        o2.AddProduct(p5);


        Console.Clear();

        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine(o1.TotalShippingCost());

        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine(o2.TotalShippingCost());
    }
}