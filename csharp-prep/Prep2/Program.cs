using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string kpreplie = Console.ReadLine();
        int kpgradep = int.Parse(kpreplie);


        string letter = "";

        if  (kpgradep >= 90)
        {
            letter = "A";
        }
        else if (kpgradep >= 80)
        {
            letter = "B";
        }
        else if (kpgradep >= 70)
        {
            letter = "C";
        }
        else if (kpgradep >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}! ");
        if (kpgradep >= 70)
        {
            Console.WriteLine("You did it! you passed!");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}