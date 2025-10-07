using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();
















        Square mySquare = new Square();
        mySquare.SetSide(20);
        Console.WriteLine(mySquare.GetArea());
    }
}