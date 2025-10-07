public class CloudGazingActivity : Activity
{



    public CloudGazingActivity()
    {
        base.SetDesc("This activity will help you quiet your busy mind and calm your nervous system by watching the clouds pass by.");
        base.SetName("Cloud Gazing Activity");
        
    }



    public void Run()
    {

        Console.Clear();
        Console.WriteLine("Welcome to the Cloud Gazing Activity.");
        Console.WriteLine();
        Console.WriteLine();
        base.DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" How long, in minutes, would you like for your session? ");
        int holdTime = Convert.ToInt32(Console.ReadLine());
        base.SetDuration(holdTime * 60);

        Console.WriteLine("You will be alerted when your session is done with sounds");
        ShowSpinner(base.GetDuration());

        Console.Beep(500, 1500);
        Console.Beep();      




        DisplayEndingMessage();








    }
    


}