using System;
//using System.Collections.Generic;

class Program
{








    static int preSmallNum(List<int> myNumber2)
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


        do
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
        //smallestNum = 1000; // use a larger number then found in list Help from AI. 1000 will not be found as smallest number at this time.

        smallestNum = preSmallNum(myNumbers);
        foreach (int myNumber in myNumbers) //find the smallest positive number in list
        {
            if (myNumber > 0)// use myNumber not smallestNum Help from AI
            {
                if (smallestNum > myNumber)
                    smallestNum = myNumber;

            }


        }




        Console.WriteLine($"The smallest positive number is {smallestNum}");
        myNumbers.Sort();

        Console.WriteLine($"The sum is:  {numTotal}");
        Console.WriteLine($"The average is:  {avgNum}");
        Console.WriteLine($"The largent number is:  {largestNum}");
        Console.WriteLine();

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
