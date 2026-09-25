using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        
        static float tenth(int amount)
        {
            return amount / 10;
        }

        float tithe = tenth(90);
        Console.WriteLine(tithe);



    }
}