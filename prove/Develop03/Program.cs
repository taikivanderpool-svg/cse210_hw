using System;

//I added functionality for the user to be able to view available scripture references and select 
//the reference that they want to memorize. I also made a Memorizer class to act as the central 
//hub for the other classes so as to further simplify functionality 


class Program
{
    static void Main(string[] args)
    {
        string reference1 = "Genesis 25:19-20";
        string verses1 = $"""And these are the generations of Isaac, Abraham`s son: Abraham begat Isaac: And Isaac was forty years old when he took Rebekah to wife, the daughter of Bethuel the Syrian of Padan-aram, the sister to Laban the Syrian.""";
        string reference2 = "Proverbs 3:5-6";
        string verses2 = $"""Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.""";

        Memorizer memorizer = new Memorizer();

        //adding references to the  Memorizer class
        memorizer.AddReference(reference1, verses1);
        memorizer.AddReference(reference2, verses2);

        memorizer.PickReference(); 


        string endProgram = "";

        memorizer.Display();
        Console.WriteLine("");
        Console.WriteLine($"""Press enter to memorize the verse; Type "quit" to quit memorizing""");

        endProgram = Console.ReadLine();


        while (endProgram != "quit")
        {
            Console.Clear();
            memorizer.IncreaseDifficulty();
            Console.WriteLine("");
            Console.WriteLine("""Press enter to memorize the verse; Type "quit" to quit memorizing""");
            endProgram = Console.ReadLine();

            if (memorizer.GetCurrentReference().IsAllInvisible() == true)
            {
                endProgram = "quit";
            }
        }
    }
    
}