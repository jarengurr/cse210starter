using System;


class Program
{
    static void Main(string[] args)
    {


        string holdGuess;
        int holdMagicNum;
        int holdGuessNum;
        string exit;
        int counter = 0; 

        Random randomGenerator = new Random();

        holdMagicNum = randomGenerator.Next(1, 20);
        Console.WriteLine();
        Console.WriteLine("You will guess a number the computer picks until you guess the right number. The computer will give you a hint of if your number is too high or too low.");
        Console.WriteLine(holdMagicNum);
        do
        {
            Console.Write("What is your guess? Enter number 1 to 20 ");
            holdGuess = Console.ReadLine();
            holdGuessNum = int.Parse(holdGuess);
            counter++;
            
            if (holdMagicNum == holdGuessNum)
            {
                if (counter == 1)     
                    Console.WriteLine($"You guessed it in {counter} turn");
                else
                    Console.WriteLine($"You guessed it in {counter} turns");
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
        Console.WriteLine("This is the Exercise 3 Project.");
        Console.WriteLine();
        

    }
}