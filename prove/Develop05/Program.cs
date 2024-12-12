using System;

class Program
{
    static void Main(string[] args)
    {
        ListingActivity l1 = new ListingActivity(60);
        int i = 0;
        while (i < l1._prompts.Count())
        {
            Console.WriteLine(l1._prompts[i]);
            i++;
        }

    }
}