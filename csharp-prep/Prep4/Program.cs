using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int kpuserinput = -1;
        while (kpuserinput != 0)
        {
            Console.WriteLine("Enter number (0 to quiet):");
            string kpanswer = Console.ReadLine();
            int kpnumber = int.Parse(kpanswer);

            
            if (kpnumber != 0)
            {
                numbers.Add(kpnumber);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The max is: {max}");
    }
}