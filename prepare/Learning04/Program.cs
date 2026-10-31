using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Pale", "encapsulation");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine("---------------------------------");

        MathAssignment math1 = new MathAssignment("Riff", "calculus", "7.3", "3-6");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine("---------------------------------");

        WritingAssignment writing = new WritingAssignment("Imps", "poetry", "non-musical musical literature");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}