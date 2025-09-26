using System;
using System.ComponentModel;
using System.Globalization;
using System.IO.Enumeration;
//                                  Exceeded requirements
// added a checker to check input for menu and give a response if entered a wrong number or letter.
// added a statement when program is exited to remind the user of the importantance of a journal which may help
// user remember to think of the journal and write in the journal.
// added the ability to make a journal entry without a question. In case the user feels they need to say something
// added the time to the date in the entry
class Program
{
    static void Main(string[] args)
    {
        int holdNum = 0;
        //string 
        string holdQuestion;
        string fileName;


        Journal myJournal = new Journal(); // main journal
        Entry myWords = new Entry(); // main entry
        PromptGenerator myGenerator = new PromptGenerator();
        myGenerator.GetFile();// load questions






        while (holdNum != 8)
        {
            {
            }
            Console.WriteLine();
            Console.WriteLine("Please select one of the choices:  ");
            Console.WriteLine("1. Write without a question");
            Console.WriteLine("2. Write with a question");
            Console.WriteLine("3. Display All Journal Entries");
            Console.WriteLine("4. Display Last Entry");
            Console.WriteLine("5. Load Journal from hard drive");
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
                    Console.WriteLine();
                    Console.WriteLine("Please enter file name like Journal.txt");
                    fileName = Console.ReadLine();
                    myJournal.LoadFromFile(fileName);

                    break;
                case 6:

                    Entry myWords2 = new Entry(); // second entry just to add to journal then set to null
                    myWords2.SetDate(myWords.GetDate());
                    myWords2.SetEntryText(myWords.GetEntryText());
                    myWords2.SetPrompt(myWords.GetPrompt());
                    Entry holdEntry;
                    holdEntry = myWords;
                    myJournal.AddEntry(myWords2);
                    myWords2 = null;


                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("Please enter file name like Journal.txt");
                    fileName = Console.ReadLine();
                    myJournal.SaveToFile(fileName);
                    break;
                case 8:
                    Console.WriteLine();
                    Console.WriteLine("Every person should keep a journal and every person can keep a journal.");
                    Console.WriteLine("It should be an enlightening one and should bring great blessings and happiness to the families.");
                    Console.WriteLine("                                           President Spencer W. Kimball");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 8");
                    break;
            }








        }



    }
}
