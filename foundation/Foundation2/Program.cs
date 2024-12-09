using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1234 Old Man Lane", "Laketown", "Ohio", "USA");
        Customer c1 = new Customer(a1, "John Doe");
        Console.WriteLine(c1.InUSA());
        Console.WriteLine(a1.FullAddress());

        Product p1 = new Product("Cheap button", 0123456789, 2, 5);
        Console.WriteLine(p1.TotalCost());
    }
}