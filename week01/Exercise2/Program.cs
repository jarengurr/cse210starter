using System;


class Program
{
    static void Main(string[] args)
    {

        float gradePercentNum;
        string letter;
        string negP = "";
        float negPos;

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

        negPos = gradePercentNum % 10;


        if (negPos >= 7 && gradePercentNum < 90 && gradePercentNum > 60)
        {
            negP = "+";
        }

        if (negPos < 3 && gradePercentNum > 60)
        {
            negP = "-";
        }

        if (gradePercentNum >= 70.0)
            Console.WriteLine($"Congratulations on passing the course with the grade {letter}{negP}.");
        else
            Console.WriteLine($"You received a grade of {letter}{negP}. Good try. Don't give up, just try again.");
        Console.WriteLine("This is the Exercise 2 Project.");
        Console.WriteLine();

    }
}