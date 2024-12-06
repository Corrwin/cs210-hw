using System;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("testman123", "this video suckz");
        Console.WriteLine(c1.DisplayComment());
    }
}