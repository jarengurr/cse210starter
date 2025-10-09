using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();


        List<Shapes> myList = new List<Shapes>();












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

        myList.Add(myRect);
        myList.Add(myCirc);
        myList.Add(mySquare);
        for (int i = 0; i < myList.Count; i++)
        {
            string holdColor;
            double holdArea;

            holdArea = myList[i].GetArea();
            holdColor = myList[i].GetColor();
            Console.WriteLine($"The color is {holdColor} and the area is {holdArea}");
        }

    }
}