using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   /* This was the code used for testing everything before the full program was set up. I did not delete it so it could be re-used if nessisary.

        //test reference class and methods: Passed
        Reference r1 = new Reference("1 Nephi", 2, 3, 3);
        Console.WriteLine(r1.GetDisplayText());

        //test word class and methods: Passed
        Word w1 = new Word("Test");
        Console.WriteLine(w1.GetDisplayText());
        w1.Hide();
        Console.WriteLine(w1.GetDisplayText());
        Console.WriteLine(w1.isHidden());
        w1.Show();
        Console.WriteLine(w1.GetDisplayText());
        

        //test scripture class and methods
        Scripture s1 = new Scripture(r1, "3 And it came to pass that he was obedient unto the word of the Lord, wherefore he did as the Lord commanded him.");
        Console.WriteLine(s1.IsCompletelyHidden());
        Console.WriteLine(s1.GetDisplayText());
        s1.HideRandomWords(3);
        Console.WriteLine(s1.GetDisplayText());
        s1.HideRandomWords(3);
        Console.Clear();
        Console.WriteLine(s1.GetDisplayText());
        */


        //first, build the reference and the scripture,
        Reference Nephi = new Reference("1 Nephi", 2, 2, 3);
        Scripture Memory = new Scripture(Nephi, "And it came to pass that the Lord commanded my father, even in a dream, that he should take his family and depart into the wilderness. And it came to pass that he was obedient unto the word of the Lord, wherefore he did as the Lord commanded him.");
        
        Console.Clear();

        while (true){
            Console.WriteLine(Memory.GetDisplayText());
            Console.WriteLine("\n Press enter or type 'quit' to finish. \n");
            string userInput = Console.ReadLine();
            if (userInput == "quit"){
                Environment.Exit(0);
            }
            else {
                Memory.HideRandomWords(3);
                Console.Clear();
            }
        }

    }

}