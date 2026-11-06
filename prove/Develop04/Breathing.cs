

class Breathing : Activity
{
    //Constructor
    public Breathing()
    {
        SetName("Breathing");
        
        string description = """
        Welcome to the Breathing Activity.

        This activity will help you relax by walking you through breathing in and out slowly. 
        Clear your mind and focus on your breathing.

        """;
        SetDescription(description);
    }

    //methods
    public void Breath(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while (currentTime < endTime)
        {
            BreathIn();
            Console.WriteLine("");
            BreathOut();
            Console.WriteLine("""
            

            """);
            currentTime = DateTime.Now;
        }

        Congradulate();
    }

    //display all of the text to the console to direct the user to breath in
    private void BreathIn()
    {
        Console.Write("Breath in for 4 seconds...");
        for (int i = 1; i < 5; i++){
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }

    //display all of the text to the console to direct the user to breath Out
    private void BreathOut()
    {
        Console.Write("And breath out for 8 seconds...");
        for (int i = 1; i < 9; i++){
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }
}