using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        float gradePercentNum;
        string letter;

        Console.Write("Please Enter your grade percentange:");
        string gradePercent = Console.ReadLine();
        gradePercentNum = float.Parse(gradePercent);


        if (gradePercentNum >= 90)
            letter = "A";
        else if (gradePercentNum >= 80.0 && gradePercentNum < 90.0)
            letter = "B";
        else if (gradePercentNum >= 70.0 && gradePercentNum < 80.0)
            letter = "C";
        else if (gradePercentNum >= 60.0 && gradePercentNum < 70.0)
            letter = "D";
        else
            letter = "F";


        if (gradePercentNum >= 70.0)
            Console.WriteLine($"Congratulations on passing the course with the grade {letter}.");
        else
            Console.WriteLine($"You received a grade of {letter}. Good try. Don't give up, just try again.");

    }
}