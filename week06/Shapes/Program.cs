using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();














        Rectangle myRect = new Rectangle("blue", 5, 3);
        Console.WriteLine(myRect.GetArea());
        Console.WriteLine(myRect.GetColor());
        Console.WriteLine();
        Circle myCirc = new Circle("green", 10);
        Console.WriteLine(myCirc.GetArea());
        Console.WriteLine(myCirc.GetColor());
        Console.WriteLine();
        Square mySquare = new Square("red", 25);

        mySquare.SetSide(20);
        Console.WriteLine(mySquare.GetArea());
        Console.WriteLine(mySquare.GetColor());
    }
}