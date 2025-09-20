using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int holdNum = 0;
        string holdDate;
        Entry myWords = new Entry();
        Journal myJournal = new Journal();
        PromptGenerator myGenerator = new PromptGenerator();
        myGenerator.GetFile();
        


        while (holdNum != 8)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the choices:  ");
            Console.WriteLine("1. Write without a question");
            Console.WriteLine("2. Write with a question");
            Console.WriteLine("3. Write with a motivation");
            Console.WriteLine("4. Display All Journal");
            Console.WriteLine("5. Display Last");
            Console.WriteLine("6. Load Journal****check");
            Console.WriteLine("7. Save Journal entry");
            Console.WriteLine("8. Quit program");
            Console.WriteLine("9. Save Journal***`");
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
                    myWords.EnterTextPlusQuestion();
                    break;
                case 3:
                    myGenerator.GetFile();
                    break;
                case 4:
                    myJournal.DisplayAll();
                    break;
                case 5:
                    myWords.Display();
                    break;
                case 6:
                    myJournal.LoadFromFile("Journal.txt");
                    holdDate = myWords.getDate();
                    Console.WriteLine(holdDate);
                    holdDate = myJournal._entries[0].getDate();
                    Console.WriteLine(holdDate);

                    break;
                case 7:
                    myJournal.AddEntry(myWords);
                    break;
                case 8:
                    break;
                case 9:
                    myJournal.SaveToFile("Journal.txt");
                    break;
                case 10:
                    Console.WriteLine("Please enter a number between 1 and 8");
                    break;
            }








        }
        
            

    }
}
