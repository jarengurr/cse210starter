using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> myNumbers;
        myNumbers = new List<int>();
        int theNumber;
        Double countList;
        Double avgNum = 0;
        int largestNum = 0;
        Double numTotal = 0;


        do
        {
            
            theNumber = int.Parse(Console.ReadLine());

            if (theNumber != 0) // take the number entered in by person and add to list
            {
                // myNumbers.Add(theNumber);

            }


        } while (theNumber != 0);

        countList = myNumbers.Count; // get the count of items in list

        foreach (int myNumber in myNumbers) // total up all the numbers in the list
        {
            numTotal += myNumber;
        }

        avgNum = numTotal / countList; // find the avg of the numbers in list

        foreach (int myNumber in myNumbers) //find the largest number in list
        {
            if (largestNum < myNumber)
                largestNum = myNumber;

        }


        Console.WriteLine($"The sum is:  {numTotal}");
        Console.WriteLine($"The average is:  {avgNum}");
        Console.WriteLine($"The largent number is:  {largestNum}");





    }
}