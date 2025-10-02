using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        string aName = "Samuel Bennett";
        string aTopic = "Multiplication";
        string aSection = "7.3 ";
        string aProblem = " 8-19 ";
        string aTitle = "The Causes of World War II";

        Assignment myWork = new Assignment(aName, aTopic);
        Console.WriteLine();
        Console.WriteLine(myWork.GetSummary());
        Console.WriteLine();

        aName = "Roberto Rodriguez";
        aTopic = "Fractions";
        MathAssignment theWork = new MathAssignment(aName, aTopic, aSection, aProblem);
        
        Console.WriteLine();
        Console.WriteLine(theWork.GetSummary());
        Console.WriteLine(theWork.GetHomeworkList());
        
        Console.WriteLine();


        aName = "Mary Waters";
        aTopic = "European History";
        WritingAssignment aWork = new WritingAssignment(aName, aTopic, aTitle);
        Console.WriteLine();
         Console.WriteLine(aWork.GetSummary());
        Console.WriteLine(aWork.GetWritingInformation());
       
        Console.WriteLine();
       
        Console.WriteLine("Hello World! This is the Homework Project.");
    }
}