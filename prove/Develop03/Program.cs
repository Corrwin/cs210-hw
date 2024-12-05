using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //test reference class and methods: Passed
        Reference r1 = new Reference("1 Nephi", 2, 3, 7);
        Console.WriteLine(r1.GetDisplayText());

        //test word class and methods: Passed
        Word w1 = new Word("Test");
        Console.WriteLine(w1.GetDisplayText());
        w1.Hide();
        Console.WriteLine(w1.GetDisplayText());
        Console.WriteLine(w1.isHidden());
        w1.Show();
        Console.WriteLine(w1.GetDisplayText());
    }
    
}