using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{// I added a random scripture picker so the user gets a random scripture to learn.

    static void Main(string[] args)
    {
        // the list of scriptures******************************
        string theScripture2 = " The fear of the Lord is the beginning of knowledge: but fools despise wisdom and instruction. My son, hear the instruction of thy father, and forsake not the law of thy mother";
        string theScripture = " Wherefore, I write unto my people, unto all those that shall receive hereafter these things which I write, that they may know the judgments of God, that they come upon all nations, according to the word which he hath spoken.";
        string theScripture3 = " Happy is the man that findeth wisdom, and the man that getteth understanding. For the merchandise of it is better than the merchandise of silver, and the gain thereof than fine gold.";
        string book1 = "2nd Nephi";
        string book2 = "Proverbs";
        string book3 = "Proverbs";
        int chapter = 25;
        int chapter2 = 1;
        int chapter3 = 3;
        int verse = 3;
        int verse2 = 7;
        int verse3 = 13;
        int endVerse3 = 14;
        //*****************************************************
        int code = 0;

        Reference theRef = new Reference(book1, chapter, verse);
        Reference theRef2 = new Reference(book2, chapter2, verse2);
        Reference theRef3 = new Reference(book3, chapter3, verse3, endVerse3);
        Random randomNum = new Random(); //random number gen for switch
        code = randomNum.Next(1,4);

       
          
     
     
        switch (code)// picks a random scripture to learn
        {
            case 1:
                //keep first one
                break;
            case 2:
                theRef = theRef2;
                theScripture = theScripture2;
                break;
            case 3:
                theRef = theRef3;
                theScripture = theScripture3;
                break;
            default:
                // just do first one
                break;


        }
        
         Scripture aScripture = new Scripture(theRef, theScripture);

        string answer=" ";
        string fullScripture;
        string holdDisplay;
        Console.Clear();
        //Console.Write($" {theRef.GetBook()} {theRef.GetChapter()}:{theRef.GetVerse()   }");
        holdDisplay = theRef.GetDisplayText();
        Console.Write(holdDisplay); //to display text of reference
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
            holdDisplay = theRef.GetDisplayText();
            Console.Write(holdDisplay);
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