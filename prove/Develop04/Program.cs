using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        int directive = 0;
        int time = 0;

        //loops until the user enters "4" to quit the program
        while (directive != 4)
        {
            Console.Clear();
            Console.WriteLine("""
            Menu Options: 
                1. Start breathing activity
                2. Start reflection activity
                3. start listing activity
                4. Quit
            """);
            Console.Write("Select a choice from the menu ");
            
            directive = int.Parse(Console.ReadLine());
            
            //checks what the user input directive is and runs accordingly
            switch (directive)
            {
                case 1:
                    Breathing breath = new Breathing();
                    time = breath.GetReady();
                    breath.Breath(time);
                    break;
                case 2:
                    Reflection reflect = new Reflection();
                    time = reflect.GetReady();
                    reflect.Reflect(time);
                    break;
                case 3:
                    Listing listing = new Listing();
                    time = listing.GetReady();
                    listing.List(time);
                    break;
            }
        }



    //base code to start each of the activities

        // Breathing breath = new Breathing();
        // int time = breath.GetReady();
        // breath.Breath(time);

        // Reflection reflect = new Reflection();
        // int time = reflect.GetReady();
        // reflect.Reflect(time);

        // Listing listing = new Listing();
        // int time = listing.GetReady();
        // listing.List(time);
    }
}