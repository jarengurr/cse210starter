using System;
using System.Security.Cryptography.X509Certificates;






class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        string name;
        Console.Write("Please enter your name:  ");
        name = Console.ReadLine();


        return name;

    }

    static int PromptUserNumber()
    {
        int favNumber;
        Console.Write("Please enter your favorite number:  ");
        favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int sqNumber;
        sqNumber = number * number;
        return sqNumber;
    }

    static void DisplayResult(int sqNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {sqNumber}");
    }





    static void Main(string[] args)
    {
        string theName;
        int theNumber;
        int squareNum;

        Console.WriteLine();

        DisplayWelcome();


        theName = PromptUserName();

        theNumber = PromptUserNumber();

        squareNum = SquareNumber(theNumber);

        DisplayResult(squareNum, theName);

        Console.WriteLine();
        Console.WriteLine("This is the Exercise 5 Project.");
        Console.WriteLine();








    }
}