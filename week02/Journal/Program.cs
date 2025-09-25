using System;
using System.ComponentModel;
using System.Globalization;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int holdNum = 0;
        string holdDate;
        string holdQuestion;
        string fileName;
        
        
        Journal myJournal = new Journal();
        Entry myWords = new Entry();
        PromptGenerator myGenerator = new PromptGenerator();
        myGenerator.GetFile();// load questions

        
       
        

        
        while (holdNum !=8)
        {
            {
        }
            Console.WriteLine();
            Console.WriteLine("Please select one of the choices:  ");
            Console.WriteLine("1. Write without a question");
            Console.WriteLine("2. Write with a question");
            Console.WriteLine("3. Display All Journal");
            Console.WriteLine("4. Display Last");
            Console.WriteLine("5. Load Journal from hard drive****check");
            Console.WriteLine("6. Save Journal entry");
            Console.WriteLine("7. Save Journal to hard drive");
            Console.WriteLine("8. Quit program");
            Console.Write("  ENTER HERE:> ");
            string inputNum = Console.ReadLine();
            bool isTrue = int.TryParse(inputNum, out holdNum); // check number
            if (!isTrue)
                holdNum = 10;

            switch (holdNum)
            {
                case 1:
                    myWords.EnterTextOnly();
                    break;
                case 2:
                    holdQuestion = myGenerator.GetRandomPrompt();
                    myWords.EnterTextPlusQuestion(holdQuestion);
                    break;
                case 3:
                    myJournal.DisplayAll();
                    break;
                case 4:
                    myWords.Display();
                    break;
                case 5:
                    myJournal.LoadFromFile("Journal.txt");
                    holdDate = myWords.getDate();
                    Console.WriteLine(holdDate);
                    holdDate = myJournal._entries[0].getDate();
                    Console.WriteLine(holdDate);

                    break;
                case 6:
                    
                    Entry myWords2 = new Entry();
                    myWords2.setDate(myWords.getDate());
                    myWords2.setEntryText(myWords.getEntryText());
                    myWords2.setPrompt(myWords.getPrompt());
                    Entry holdEntry;
                    holdEntry = myWords;
                    //myJournal.AddEntry(holdEntry);
                    myJournal.AddEntry(myWords2);
                    myWords2 = null;
                    //myWords = null;
                    
                    break;
                case 7:

                    Console.WriteLine("Please enter file name like Journal.txt");
                    fileName = Console.ReadLine();
                    myJournal.SaveToFile(fileName);
                    break;
                case 8:
                    Console.WriteLine("Good By");
                    break;
                case 10:
                    Console.WriteLine("Please enter a number between 1 and 8");
                    break;
            }








        }
        
            

    }
}
