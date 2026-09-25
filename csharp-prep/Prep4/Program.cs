using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> sortedNums = new List<int>();
        int request = -1;
        int total = 0;
        int largest = -1;
        int smallest = 99999999;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (request != 0)
        {
            Console.Write("Enter number: ");
            request = int.Parse(Console.ReadLine());
            if (request != 0)
            {
                numbers.Add(request);
            }
        }

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
            total += number;
        }

        float average = (float)total / (numbers.Count);
        numbers.Sort();


        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");

        Console.WriteLine($"The list sorted is: ");

        foreach (int num in numbers)
        {
        Console.WriteLine(num);
        }
    }
}