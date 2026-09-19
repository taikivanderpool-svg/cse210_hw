using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? "); 
        string stringGrade = Console.ReadLine(); 
        float gradePercentage = float.Parse(stringGrade);
        string letter = "";


        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";

        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        float remainder = gradePercentage % 10; 
        string plusOrMinus = "";

        if (!(gradePercentage >=90 || gradePercentage < 70))
        {
            if (remainder >= 7) 
                {
                    plusOrMinus = "+";
                }
            else if (remainder < 3)
            {
                plusOrMinus = "-";
            }
        }

        if (gradePercentage >=70)
        {
            Console.WriteLine($"Congradulations, at {gradePercentage}% you have passed with a {letter}{plusOrMinus}.");
        }
        else
        {
            Console.WriteLine($"Unfortunately at {gradePercentage} you have not passed with a {letter}{plusOrMinus}, but you can do it, try again next time.");
        }
    }
}