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
    public List<Entry> _kpentries = new List<Entry>();
    public List<string> _kpPrompt = new List<string>();
    public string _kpfilename; 

    public void DisplayMenu()
    {
        // Prints out the list of options the user can choose from
        Console.WriteLine("1. Display \n 2. Write Entry \n 3. Save \n 4. Load \n 5. Quit");
    }

    public void Display()
    {
        foreach(Entry entry in _kpentries )
        {
            //prints out and lods to entry to then display to Program.cs
            Console.WriteLine($"{entry._kpdate} \n {entry._kpprompt} \n {entry._kpwords}");

        }

    }
    
    public void Save()
    {
        //Ask the user for a file perferable "myFile.txt"
        Console.WriteLine("What file would you like? ");
        _kpfilename = Console.ReadLine();

        //Saves the entries date, the prompt qiven, the word the user typed
        using (StreamWriter outputFile = new StreamWriter(_kpfilename))
        {
            foreach (Entry entry in _kpentries)
            {
                outputFile.WriteLine($"{entry._kpdate}, {entry._kpprompt}, {entry._kpwords}");
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
        string randprompt = this._kpPrompt[rand.Next(6)];
        Console.WriteLine(randprompt);
        string kpuserentry = Console.ReadLine();

        //saves this into entry objects
        entry._kpwords = kpuserentry;
        entry._kpdate = dateText; 
        entry._kpprompt = randprompt;
        
        // adds this new entry to entry
        _kpentries.Add(entry);


    }

    public void Load()
    {
        // when the user is ask "which file do you choose?" to save to and the user choose "myFile.txt" entries will be loaded.
        string kpmyfilename = "myFile.txt"; 
        string[] lines = System.IO.File.ReadAllLines(kpmyfilename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(","); 
            Entry entry = new Entry
            {
              _kpdate = parts[0],
              _kpprompt = parts[1]
            };
        }
    }

}

