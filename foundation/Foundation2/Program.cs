using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1234 Old Man Lane", "Laketown", "Ohio", "USA");
        Console.WriteLine(a1.InUSA());
        Console.WriteLine(a1.FullAddress());
    }
}