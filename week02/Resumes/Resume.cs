using System;
public class Resume
{
    // Member variables
    public string _name;

    //Initialize the list to a new List
    public List<Job> _jobs = new List<Job>();

    // Methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }
}