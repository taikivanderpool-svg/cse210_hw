// using System;
// using System.Globalization;
// using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
    List<string> test = ["a", "b", "c", "d"];

    Console.WriteLine(test[0]);
    Console.WriteLine(test[1]);
    Console.WriteLine(test[2]);
    Console.WriteLine(test[3]);


    List<string> test2 = test;


    Console.WriteLine(test2[0]);
    Console.WriteLine(test2[1]);
    Console.WriteLine(test2[2]);
    Console.WriteLine(test2[3]);
    }
}