using System;
using System.Collections.Generic;



List<int> myNumbers;
myNumbers = new List<int>();
int theNumber;
Double countList;
Double avgNum = 0;
int largestNum = 0;
Double numTotal = 0;
int smallestNum = 0;


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

foreach (int myNumber in myNumbers) //find the largest number in list
{
    if (largestNum < myNumber)
        largestNum = myNumber;

}

foreach (int myNumber in myNumbers) //find the largest number in list
{
    if (smallestNum < myNumber && smallestNum > 0)
        smallestNum = myNumber;

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

Console.WriteLine("This is the Exercise 4 Project.");
