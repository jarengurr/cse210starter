using System;

class Program
{
    static void Main(string[] args)
    {


        string holdGuess;
        int holdMagicNum;
        int holdGuessNum;
        string exit;
        Random randomGenerator = new Random();

        holdMagicNum = randomGenerator.Next(1, 20);

        do
        {
            Console.Write("What is your guess? Enter number 1 to 20 ");
            holdGuess = Console.ReadLine();
            holdGuessNum = int.Parse(holdGuess);

            if (holdMagicNum == holdGuessNum)
            {
                Console.WriteLine("You guessed it!");
                exit = "out";
            }

            else if (holdMagicNum > holdGuessNum)
            {
                Console.WriteLine("Higher");
                exit = "zero";
            }
            else
            {
                Console.WriteLine("Lower");
                exit = "zero";
            }

        } while (exit == "zero");
    Console.WriteLine("Hello World! This is the Exercise 3 Project.");
        

    }
}