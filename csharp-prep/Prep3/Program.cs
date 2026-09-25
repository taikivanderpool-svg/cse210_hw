using System;

class Program
{
    static void Main(string[] args)
    {

        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int magicGuess = -1;
        
        int guesses = 0;

        while (!(magicGuess == magicNumber))
        {

        Console.Write("Guess the magic number? ");
        string guess = Console.ReadLine();
        magicGuess = int.Parse(guess);
        
        if (magicGuess > magicNumber)
        {
            Console.WriteLine("Lower ");
            guesses ++;
        }
        else if (magicGuess < magicNumber)
        {
            Console.WriteLine("higher");
            guesses ++;
        }
        else
        {
            guesses ++;
            Console.WriteLine($"Congradulations, you guessed it in {guesses} attempts.");
        }
        }

    }   
}