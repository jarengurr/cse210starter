public class Resume()
{
    public string _userName;
    public List<Job> _job = new List<Job>();
    public Job myjob;
    private int count = 0;

    
    public void Add(Job hold)
    {
        _job[count]= hold;
        count = count + 1;
    }

    public void displayAllJobs()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _job)
            job.DisplayJobInfo();
    }
}