using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
/*
Journal Class 
Runing the functions Display, Save, Write_entry, Load, and quit. 
Kamas Peterson 
(c) 2023
*/

public class Journal
{
    public List<Entry> _kpEntries = new List<Entry>();
    public List<string> _kpPrompt = new List<string>();
    public string _kpFilename; 

    public void DisplayMenu()
    {
        // Prints out the list of options the user can choose from
        Console.WriteLine("1. Display \n 2. Write Entry \n 3. Save \n 4. Load \n 5. Quit");
    }

    public void Display()
    {
        foreach(Entry entry in _kpEntries )
        {
            //prints out and lods to entry to then display to Program.cs
            Console.WriteLine($"{entry._kpDate} \n {entry._kpPrompt} \n {entry._kpWords}");

        }

    }
    
    public void Save()
    {
        //Ask the user for a file perferable "myFile.txt"
        Console.WriteLine("What file would you like? ");
        _kpFilename = Console.ReadLine();

        //Saves the entries date, the prompt qiven, the word the user typed
        using (StreamWriter outputFile = new StreamWriter(_kpFilename))
        {
            foreach (Entry entry in _kpEntries)
            {
                outputFile.WriteLine($"{entry._kpDate}, {entry._kpPrompt}, {entry._kpWords}");
            }
            
        }
    }

    public void Write_entry()
    {
        //  Starts a new entry
        Entry entry = new Entry();

        //When the user writes and will display the date of when the entry was written
        DateTime theCurrentTime = DateTime.Now; 
        string dateText = theCurrentTime.ToShortDateString(); 
        
        // Use random to interate through the prompts in the prompt list.
        Random rand = new Random(); 
        string randPrompt = this._kpPrompt[rand.Next(6)];
        Console.WriteLine(randPrompt);
        string kpuserentry = Console.ReadLine();

        //saves this into entry objects
        entry._kpWords = kpuserentry;
        entry._kpDate = dateText; 
        entry._kpPrompt = randPrompt;
        
        // adds this new entry to entry
        _kpEntries.Add(entry);


    }

    public void Load()
    {
        // when the user is ask "which file do you choose?" to save to and the user choose "myFile.txt" entries will be loaded.
        string kpmyFilename = "myFile.txt"; 
        string[] lines = System.IO.File.ReadAllLines(kpmyFilename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(","); 
            Entry entry = new Entry
            {
              _kpDate = parts[0],
              _kpPrompt = parts[1]
            };
        }
    }

}

