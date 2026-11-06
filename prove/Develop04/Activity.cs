

class Activity
{
    //Attributes 
    private string _activityName;
    private string _description;
    private int _activityDuration;

    
    //Methods
        //setter
        //this setter will be used within the child classes to set the description
        public void SetDescription(string description)
    {
        _description = description;
    }

    //setter
    public void SetName(string name)
    {
        _activityName = name;
    }

//clears the console and displays the description of the chosen activity from _description
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

//asks the user how long they want to do the chosen activity and returns their response as an int
    public int AskHowLong()
    {
        Console.Write("How long, in seconds, would you like to do the activity: ");
        int seconds = int.Parse(Console.ReadLine());
        _activityDuration = seconds;
        return seconds;
    }

//takes an int as a perameter and displays a spinner for the input number of seconds
    public void DisplaySpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        List<string> list = ["|", "/", "-", "\\"];
        int counter = 0;
        while (currentTime < endTime)
        {
            if (counter > 3)
            {
                counter = 0;
            }
            Console.Write(list[counter]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
            counter ++;
        }
    }

    public void DisplayConclusion()
    {
        Console.WriteLine($"""Congradulations! You did the {_activityName} activity for {_activityDuration} seconds!""");
        DisplaySpinner(5);
    }

    //displays all of the introduction common across all activities and returns an integer amount of seonds
    public int GetReady()
    {
        Console.Clear();
        DisplayDescription();
        int duration = AskHowLong();

        Console.Clear();
        Console.WriteLine("""
        Get ready...
        """);
        DisplaySpinner(4);
        return duration;
    }

    public void Congradulate()
    {
        Console.WriteLine("Well done!");
        DisplaySpinner(4);
        Console.WriteLine("");
        DisplayConclusion();
        DisplaySpinner(8);
        Console.Clear();
    }

}