using System;

class Program
{
    static void Main(string[] args)
    {
        string theName;
        Job job1 = new Job();
        
        job1._jobCompany = "Microsoft";
        job1._jobEndYear = "2022";
        job1._jobStartYear = "2019";
        job1._jobTitle = "Software Engineer";
        
        

        Job job2 = new Job();

        job2._jobCompany = "Apple";
        job2._jobTitle = "Manager";
        job2._jobStartYear = "2022";
        job2._jobEndYear = "2023";


        
        theName = "Bob Smith";
        Resume resume1 = new Resume();
        resume1._userName = theName;
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        Console.WriteLine();
        resume1.displayAllJobs();
        Console.WriteLine();
        



    }
}