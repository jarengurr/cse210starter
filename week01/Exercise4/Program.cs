using System;


class Program
{


    static int PreSmallNum(List<int> myNumber2)// find positive number in a list and return a -1 if no positive numbers are found.
    {
        int hold = -1;

        for (int x = 0; x < myNumber2.Count; x++)
        {
            if (myNumber2[x] > 0)
            {
                hold = myNumber2[x];
            }
        }

        return hold;

    }
    

    static void Main(string[] args)
    {

        List<int> myNumbers;
        myNumbers = new List<int>();
        int theNumber;
        Double countList;
        Double avgNum = 0;
        int largestNum;
        Double numTotal = 0;
        int smallestNum;


        do // loop to enter numbers
        {
            Console.WriteLine("Please Enter a number to add to a list.");

            theNumber = int.Parse(Console.ReadLine());

            if (theNumber != 0) // take the number entered in by person and add to list
            {
                myNumbers.Add(theNumber);

            }


        } while (theNumber != 0);

        countList = myNumbers.Count; // get the count of items in list

        foreach (int myNumber in myNumbers) // total up all the numbers in the list
        {
            numTotal += myNumber;
        }

        avgNum = numTotal / countList; // find the avg of the numbers in list

        largestNum = myNumbers[0];
        foreach (int myNumber in myNumbers) //find the largest number in list
        {
            if (largestNum < myNumber)
                largestNum = myNumber;

        }
        //*******************************  Question: is zero a positive number for this assignment?
        smallestNum = PreSmallNum(myNumbers); // find a positive number in the list. It will return a -1 if no positive numbers are found.
        foreach (int myNumber in myNumbers) //find the smallest positive number in list
        {
            if (myNumber > 0)// use myNumber not smallestNum Help from AI
            {
                if (smallestNum > myNumber)
                    smallestNum = myNumber;

            }


        }




        
        myNumbers.Sort();

        Console.WriteLine($"The sum is:  {numTotal}");
        Console.WriteLine($"The average is:  {avgNum}");
        Console.WriteLine($"The largent number is:  {largestNum}");
        Console.WriteLine($"The smallest positive number is {smallestNum}");
        Console.WriteLine("The sorted list is: ");

        for (int count = 0; count < myNumbers.Count; count++)// print out list
        {
            Console.WriteLine(myNumbers[count]);
        }

        Console.WriteLine();
        if (smallestNum < 0)
            Console.WriteLine("No positive number found in list");

        Console.WriteLine("This is the Exercise 4 Project.");
    }
}
