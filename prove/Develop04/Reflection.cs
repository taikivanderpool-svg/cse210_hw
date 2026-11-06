

class Reflection : Activity
{
    //Attributes
    private List<string> _questions = [
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    ];

    //Constructors
    public Reflection()
    {
        SetName("Reflection");

        string description = """
        Welcome to the reflection activity.

        This activity will help you reflect on times in your life when you have shown strength and 
        resilience. This will help you recognize the power you have and how you can use it in other 
        aspects of your life.

        """;
        SetDescription(description);
    }

    //methods
    public void Reflect(int duration)
    {
        List<string> prompts = [
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?", 
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?", 
            "Who are some of your personal heroes?"
        ];
        List<string> questions = _questions;

        //if the program runs out of questions, it will refresh and begin reusing questions
        if (questions.Count() == 0)
        {
            questions = _questions;
        }
        
        Random random = new Random();
        string prompt = prompts[random.Next(0, prompts.Count())];

        Console.WriteLine($"""
        Consider the following prompt:

        ---{prompt}---

        When you have something in mind press enter to continue.
        """);
        Console.ReadLine();

        Console.Write("""
        Now ponder each of the following questions as they relate to this experience.
        You may begin in 
        """);
        for (int i = 5; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();


        //questioning portion of the exercise: the real meat of this activity: the actual real activity
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        while (currentTime < endTime)
        {
            string currentQuestion = questions[random.Next(0, questions.Count())];
            questions.Remove(currentQuestion);
            Console.WriteLine($"> {currentQuestion}");
            DisplaySpinner(8);
            currentTime = DateTime.Now;
        }
        
        Congradulate();

    }
}