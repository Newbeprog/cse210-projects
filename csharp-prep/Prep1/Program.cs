using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your first name?");
        string kpfname = Console.ReadLine();

        Console.Write("What is your last name?");
        string kplname = Console.ReadLine();

       Console.Write($"Your name is {kplname}, {kpfname} {kplname}");

    }
}
