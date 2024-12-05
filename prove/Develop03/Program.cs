using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("1 Nephi", 2, 3, 7);
        Console.WriteLine(r1.GetDisplayText());
    }
}