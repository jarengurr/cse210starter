using System;

class Program
{


    static void Main(string[] args)
    {
        int holdNum = 0;
        string randPrompt1 = "Think of a time when you stood up for someone.";
        string randPrompt2 = "Think of a time when you did something really difficult.";
        string randPrompt3 = "Think of a time when you helped someone in need.";
        string randPrompt4 = "Think of a time when you did something truly selfless.";

        string randomQuestion1 = "Why was this experience meaningful to you?";
        string randomQuestion2 = "How did you get started?";
        string randomQuestion3 = "How did you feel when it was complete?";
        string randomQuestion4 = "What made this time different than other times when you were not as successful?";
        string randomQuestion5 = "What is you favorite thing about this experience?";
        string randomQuestion6 = "What could you learn from this experience that applies to other situations?";
        string randomQuestion7 = "Have you ever done anything like this before?";
        string randomQuestion8 = "What did you learn about yourself through this experience?";
        string randomQuestion9 = "How can you keep this experience in mind in the future?";


        string reflectMessage1 = "Who are people that you appreciate?";
        string reflectMessage2 = "What are personal strengths of yours?";
        string reflectMessage3 = "Who are people that you have helped?";
        string reflectMessage4 = "When have you felt the Holy Ghost this month?";
        string reflectMessage5 = "Who are some of you personal heroes?";
        

        ReflectingActivity holdReflect = new ReflectingActivity();
        holdReflect.AddPrompt(randPrompt1);
        holdReflect.AddPrompt(randPrompt2);
        holdReflect.AddPrompt(randPrompt3);
        holdReflect.AddPrompt(randPrompt4);
        holdReflect.AddQuestion(randomQuestion1);
        holdReflect.AddQuestion(randomQuestion2);
        holdReflect.AddQuestion(randomQuestion3);
        holdReflect.AddQuestion(randomQuestion4);
        holdReflect.AddQuestion(randomQuestion5);
        holdReflect.AddQuestion(randomQuestion6);
        holdReflect.AddQuestion(randomQuestion7);
        holdReflect.AddQuestion(randomQuestion8);
        holdReflect.AddQuestion(randomQuestion9);
        ListingActivity myList = new ListingActivity();
        myList.AddQuestion(reflectMessage1);
        myList.AddQuestion(reflectMessage2);
        myList.AddQuestion(reflectMessage3);
        myList.AddQuestion(reflectMessage4);
        myList.AddQuestion(reflectMessage5);

        
        BreathingActivity hold = new BreathingActivity();
        CloudGazingActivity holdCloud = new CloudGazingActivity();


        
        while (holdNum != 5)
        {


            Console.WriteLine();
            Console.WriteLine("Please select one of the choices:  ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflectiong Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Cloud Gazing Activity");
            Console.WriteLine("5. Quit program");
            Console.Write("  ENTER HERE:> ");
            string inputNum = Console.ReadLine();
            bool isTrue = int.TryParse(inputNum, out holdNum); // check number
            if (!isTrue)
                holdNum = 10;

            switch (holdNum)
            {
                case 1:
                    
                    hold.Run();
                    break;
                case 2:

                    holdReflect.Run();
                    break;
                case 3:
                    
                    myList.Run();

                    break;
                case 4:
                    
                    holdCloud.Run();
                    break;
                case 5:
                    Console.WriteLine("Good Job");

                    break;


                default:
                    Console.WriteLine("Please enter a number between 1 and 5");
                    break;
            }




        }
    }
}