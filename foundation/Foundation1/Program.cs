using System;

class Program
{
    static void Main(string[] args)
    {                
                   //create videos
        Video v1 = new Video("Go! BWWAAA", "Romain", 3);    
        Video v2 = new Video("You Face Jaraxxus!", "SmashieSmash", 133);
        Video v3 = new Video("First Upload", "yomama", 79);
        Video v4 = new Video("Let's Play Henry Stikman - EP 29", "SticMaster99", 1234);
        Console.Clear();


                //create comments for each video
        v1.AddComment("That's the Wendy's way", "hensleyy8925");
        v1.AddComment("No human on earth has watched this once", "emadmohamed4999");
        v1.AddComment("I hope the ground is ok", "Vegetsu101");
        v1.AddComment("How it feels to chew 5 Gum.", "1776_Was_Great");
        v2.AddComment("This really takes me back. To a simpler, better time. When three wins was 10 gold.", "Waffar7539");
        v2.AddComment("MWAHAHAHAHAHA! I LOVE IT! GOOD JOB TINY HUMAN!", "lordjaraxxus7141");
        v3.AddComment("first", "biteof87");
        v3.AddComment("also this video suckz", "biteof87");
        v3.AddComment("it has been five years and I graduated college. this video still suckz", "biteof87");
        v4.AddComment("You actually made it a real video. props to you", "Gorgonzilla");
        v4.AddComment("I only got 37/57 references", "MuteButton69");
        v4.AddComment("I rate this video with 13 Eagles per Gun", "AverageAmerican");

        //then writeline the outputs
        Console.WriteLine(v1.DisplayAllInfo());        
        Console.WriteLine(v2.DisplayAllInfo());
        Console.WriteLine(v3.DisplayAllInfo());
        Console.WriteLine(v4.DisplayAllInfo());
    }
}