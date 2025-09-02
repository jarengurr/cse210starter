using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int holdNum = 0;
        Entry myWords = new Entry();
        PromptGenerator myGenerator = new PromptGenerator();
        
        


        while (holdNum != 8)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the choices:  ");
            Console.WriteLine("1. Write without a question");
            Console.WriteLine("2. Write with a question");
            Console.WriteLine("3. Write with a motivation");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Display Last");
            Console.WriteLine("6. Load Journal");
            Console.WriteLine("7. Save Journal entry");
            Console.WriteLine("8. Quit program");
            Console.Write("  ENTER HERE:> ");
            string inputNum = Console.ReadLine();
            bool isTrue = int.TryParse(inputNum, out holdNum);
            if (!isTrue)
                holdNum = 9;

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
                    break;
                case 5:
                    myWords.Display();
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    Console.WriteLine("Please enter a number between 1 and 8");
                    break;
            }








        }
        
            

    }
}
