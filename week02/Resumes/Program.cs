using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        List<Job> jobs = new List<Job> { job1, job2 };


        Resume myResume = new Resume("John Doe", jobs);

        myResume.Display();

    }
}
