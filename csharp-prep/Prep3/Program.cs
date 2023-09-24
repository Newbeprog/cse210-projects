using System;
using System.Security.Cryptography;
//Programing with Class
//Prep 3 
//Kamas Peterson
//Get the user to guess the magic number
//(c) 2023
class Program
{
    static void Main(string[] args)
    {
        
        Random numberGenorator = new Random();
        int magicNumber = numberGenorator.Next(1,100);


        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            int kpyourguess = int.Parse(Console.ReadLine());


            if (kpyourguess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            
            else if (kpyourguess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        
        
        
        
    }
}