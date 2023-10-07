using System;

/*
Designer  
Create a journal that gives the users prompts on what to write, displays entries, saves and loads. 
Kamas Peterson 
(c)2023
*/

class Program
{
    static void Main(string[] args)
    {
        // starts a new Journal
        Journal journal = new Journal();
        // adds these five prompts to the kpprompt list.
        journal._kpPrompt.Add("What is something that made you smile today?"); 
        journal._kpPrompt.Add("Describe your day in 5 words or more!"); 
        journal._kpPrompt.Add("What are some goals that you have for yourself?and Why?"); 
        journal._kpPrompt.Add("If you had one family member you could vist today who would it be? and Why?"); 
        journal._kpPrompt.Add("What was the the hardest part of your day?"); 

        // Users choice of what they want to do
        string kpchoice = "";
        
        while (true)
        {
            Console.WriteLine("Welcome to your Journal! Are you ready to get start?"); 
            Console.WriteLine("1.Display"); 
            Console.WriteLine("2.Write Entry");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Quit");
            kpchoice = Console.ReadLine(); 

            if (kpchoice == "1")
            {
            // calls the function Display in Journal
            journal.Display();

            }
            
            else if (kpchoice == "2")
            {
                // calls the function Write_entry in Journal
                journal.Write_entry();
            }

            else if (kpchoice == "3")
            {
                //calls the function Save in Journal
                journal.Save();
            }

            else if (kpchoice == "4")
            {
                //calls the function Load in Journal
                journal.Load();
            }
            
            else 
            {
                // Calls the function DisplayMenu in Journal
                journal.DisplayMenu();
            }
        }
    
        
    }
}
