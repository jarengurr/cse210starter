

public class BreathingActivity : Activity
{
    


    public BreathingActivity()
    {
        //SetDesc(_desc);
         base.SetName("Breathing Activity");
         base.SetDesc("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
        //SetDuration(seconds);
        
        
    }

    public void Run()
    {

        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine();
        base.DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" How long, in seconds, would you like for your session? ");
        int holdTime = Convert.ToInt32(Console.ReadLine());
        //Console.Beep(500, 1500);
        //Console.Beep();      
        //hold.DisplayStartingMessage();
        base.SetDuration(holdTime);
       
        Console.CursorVisible = false; // make cursor invisible
        int holdLoopNum = holdTime/ 10; ///////////////////////use seconds or _duration
        for (int m = 0; m < holdLoopNum; m++)
        {
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {

                ShowCountDown(i);
                
            }
            Console.WriteLine();
            Console.Write("Breathe out... ");

            for (int z = 6; z > 0; z--)
            {

                ShowCountDown(z);
            }

            Console.WriteLine();
        }
         Console.CursorVisible = true;// make cursor visible


        DisplayEndingMessage();

    }


}