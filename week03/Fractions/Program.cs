using System;


class Program
{



    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction myNumber = new Fraction();
        Console.WriteLine(myNumber.GetFractionString());
        Console.WriteLine(myNumber.GetDecimalValue());


        Fraction myNumber2 = new Fraction(5);
        Console.WriteLine(myNumber2.GetFractionString());
        Console.WriteLine(myNumber2.GetDecimalValue());

        Fraction myNumber3 = new Fraction(3, 4);
        Console.WriteLine(myNumber3.GetFractionString());
        Console.WriteLine(myNumber3.GetDecimalValue());
        
         Fraction myNumber4 = new Fraction(1, 3);
        Console.WriteLine(myNumber4.GetFractionString());
        Console.WriteLine(myNumber4.GetDecimalValue());

    }
}