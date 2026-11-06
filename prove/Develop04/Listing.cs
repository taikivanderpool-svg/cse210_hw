

class Listing : Activity
{
    //Constructor
    public Listing()
    {
        SetName("Listing");

        string description = """
        Welcome to the Listing activity.

        This activity will help you reflect on the good things in your life by having you list as 
        many things as you can in a certain area.

        """;
        SetDescription(description);
    }

    //methods
    public void List(int duration)
    {
        List<string> prompts = [
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?", 
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?", 
            "Who are some of your personal heroes?"
        ];

        Random random = new Random();

        Console.WriteLine($"""
        List as many responses as you can to the following prompt.

        ---{prompts[random.Next(0, prompts.Count())]}---

        """);

        Console.Write("You may begin in ");
        for (int i = 5; i > 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

        //the inputs variable is meant to keep track of how many times the user has listed something
            int inputs = 0;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while (currentTime < endTime)
        {
            TakeInput();
            currentTime = DateTime.Now;
            inputs ++;
        }

        Console.WriteLine($"You listed {inputs} items!");
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        DisplaySpinner(6);
        DisplayConclusion();
    }

    private void TakeInput()
    {
        Console.Write(">");
        Console.ReadLine();
    }
}