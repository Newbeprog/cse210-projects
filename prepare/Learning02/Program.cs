using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer Science"; 
        job1._company = "Ancestory"; 
        job1._startyear = 2027;
        job1._endyear = 2031;
        
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";
        job2._startyear = 2031;
        job2._endyear = 2036;

        Resume myResume = new Resume();
        myResume._name = "Kamas Cecily";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}