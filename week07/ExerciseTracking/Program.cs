using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> myActivity = new List<Activity>();
        string myDate = "10/12/2024";
        int myActLength = 25;
        int myDist = 100;
        int myLaps = 5;
        int mySpeed = 8;

       
        Running myRun = new Running(myDate, myActLength, myDist);
        Swimming mySwim = new Swimming(myDate, myActLength, myLaps);
        Cycling myCycle = new Cycling(myDate, myActLength, mySpeed);


        myActivity.Add(myRun);
        myActivity.Add(mySwim);
        myActivity.Add(myCycle);




        mySwim.GetSummary();
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }
}