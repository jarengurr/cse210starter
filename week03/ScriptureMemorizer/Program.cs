using System;
using System.Formats.Asn1;

class Program
{

    static void Main(string[] args)
    {
        string theScripture = " Wherefore, I write unto my people, unto all those that shall receive hereafter these things which I write, that they may know the judgments of God, that they come upon all nations, according to the word which he hath spoken.";
        Reference theRef = new Reference();
        theRef.SetBook("2nd Nephi");
        theRef.SetChapter(25);
        theRef.SetVerse(3);
        //theRef.SetEndVerse(3);


        string answer=" ";
        string fullScripture;
        Scripture aScripture = new Scripture(theRef, theScripture);
         Console.Clear();
        Console.Write($" {theRef.GetBook()} {theRef.GetChapter()}:{theRef.GetVerse()   }");
       
        //aScripture.HideRandomWords(3);
        fullScripture = aScripture.GetDisplayText();
        Console.WriteLine(fullScripture);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type quit to end.");
        answer = Console.ReadLine();
        
        while (answer != "quit")
        {
            Console.Clear();
            aScripture.HideRandomWords(3);
            fullScripture = aScripture.GetDisplayText();
            Console.Write($" {theRef.GetBook()} {theRef.GetChapter()}:{theRef.GetVerse()}  ");
            Console.WriteLine(fullScripture);
            if (aScripture.IsCompletelyHidden())
            {
                answer = "quit";
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Finished. Good Job");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue or type quit to end.");
                answer = Console.ReadLine();
            }
                
        }
    }
}