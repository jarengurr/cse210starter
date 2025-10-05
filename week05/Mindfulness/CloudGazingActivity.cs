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
    }
    


}