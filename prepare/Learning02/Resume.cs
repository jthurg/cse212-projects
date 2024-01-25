public class Resume
{

    //Define member variables.
    public string _name = "Tim Burton";
    public List<Job> _jobs = new List<Job>();



    //Define methods.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach  (Job job in _jobs)
        {
            job.DisplayJobDetails();
        } 
    }
}