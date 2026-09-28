using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantizing the job classes
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft"; 
        job1._startYear = 2019;
        job1._endYear = 2024;

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2024;
        job2._endYear = 2025;
        


        Resume person1 = new Resume();

        person1._name = "Jamie";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);

        person1.Display();
    }
}