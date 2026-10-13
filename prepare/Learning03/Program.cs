using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(4);
        Fraction fraction3 = new Fraction(2, 4);
        Console.WriteLine(fraction1.GetDecimalValue()); // 1
        Console.WriteLine(fraction1.GetFractionString());// 1/1

        Console.WriteLine(fraction2.GetDecimalValue());// 4
        Console.WriteLine(fraction2.GetFractionString());// 4/1

        Console.WriteLine(fraction3.GetDecimalValue()); //0.5
        Console.WriteLine(fraction3.GetFractionString()); // 2/4

        fraction1.SetTop(4);
        fraction1.SetBottom(5);
        Console.WriteLine(fraction1.GetTop()); // 4
        Console.WriteLine(fraction1.GetBottom()); // 5
        Console.WriteLine(fraction1.GetDecimalValue()); //0.8
        Console.WriteLine(fraction1.GetFractionString());// 4/5
        
        Fraction fraction = new Fraction();
        Random randInt = new Random();

        for (int i = 1; i < 21; i++)
        {
            fraction.SetTop(randInt.Next(1, 21));
            fraction.SetBottom(randInt.Next(1, 21));
            Console.WriteLine($"Fraction {i}: String: {fraction.GetFractionString()}: Number: {fraction.GetDecimalValue()}");
            
        }

    }
}