//Creating the Job class
using System;
public class Job()
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Memeber function to display previous job experience
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}