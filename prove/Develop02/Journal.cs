using System;
using System.IO; 

public class Journal {
    List<string> _entries = new List<string>();


    public void AddEntry(){
        //store date as local var jdate
        string jdate = DateTime.Today.ToString('MM/dd/yyyy');

        //call for a prompt and store it
        PromptGenerator jgen = new PromptGenerator();
        string jprompt = jgen.GetRandomPrompt;

        //ask for journal content and save as jcontent
        Console.Write(jprompt);
        string jcontent = Console.ReadLine();

        _entries.Add(Entry(jdate, jprompt, jcontent));
    }


                //this version of AddEntry exists SOLELY to enable load functionality. Othwise, you would get random prompts
    public void AddEntry (string jdate, string jprompt, string jcontent) {
        
        _entries.Add(Entry(jdate, jprompt, jcontent));
    }

    public void DisplayAll() {
        for (int i = 0; i < _entries.Count; i++) {
            Console.WriteLine(_entries[i].Display);
        }
    }

    public void SaveToFile (string fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {  //for each entry, create a string with Display to add to the file
            for (int i = 0; i < _entries.Count; i++) 
            {
                outputFile.WriteLine(_entries[i].Display);
            }
        }
    }


        /* Known problems with this load setup
        1. if the journal entry has a colon (:) it will not load anything past it
        2. if a journal is loaded, it is added to the currently in-progress journal.
        */
    public void LoadFromFile (string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
                
            string lDate = parts[0];
            string lPrompt = parts[1];
            string lContent = parts[2];
            AddEntry(lDate, lPrompt, lContent);
        }
    }

}