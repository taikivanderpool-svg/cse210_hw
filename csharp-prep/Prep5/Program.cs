using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        //function to greet the user
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        //function to ask and return the user their name
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        //function to ask and return the user's favorite number(as an integer)
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        //function to ask user's birth year (accepts an out parameter)
        static void PromptUserBirthYear(out int year)
        {
            Console.Write("What is your birth year? ");
            year = int.Parse(Console.ReadLine());
        }

        //function to square a number and return it (accepts an int parameter)
        static int SquareNumber(int num)
        {
            int squared = num * num; 
            return squared;
        }

        // function to calculate and display how many years old the user will 
        // turn this year and their squared number (accepts user's name(string),
        // users birth year(int), and a squared number(int))
        static void DisplayResult(string name, int year, int number)
        {
            int currentYear = DateTime.Now.Year;
            int newAge = currentYear - year;
            Console.WriteLine($"{name}, the square of your number is {number}");
            Console.WriteLine($"{name}, you will turn {newAge} this year.");
        }

        //
        //Running the functions for the message
        //

        //greet the user
        DisplayWelcome(); 

        //ask and get the user's name (as a string)
        string name = PromptUserName();

        //ask and get the user's favorite number (as an int)
        int favNum = PromptUserNumber();

        //ask and stor the user's birth year (as an int)
        int birthYear; 
        PromptUserBirthYear(out birthYear); 

        //calculates and gets the square of the user's favorite number 
        int squaredFaveNum = SquareNumber(favNum);

        //displays message to the user 
        DisplayResult(name, birthYear, squaredFaveNum);

    }
}