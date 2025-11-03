using System;
using System.Collections.Generic;

// Class Resume
public class Resume
{
    public string _name;
    public List<Job> _job;

    public Resume(string name, List<Job> job)
    {
        _name = name;
        _job = job;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _job)
        {
            job.Display();
        }
    }

}