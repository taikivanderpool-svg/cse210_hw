namespace journal;
using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = [];
    public string _fileName = "";


    public Entry AddEntry()
    {
        DateTime currentTime = DateTime.Now;

            Entry entry = new Entry();
            string prompt = PickPrompt(); 
            string response;
            string date = currentTime.ToShortDateString();

            Console.WriteLine(prompt); 
            response = Console.ReadLine();

            entry._prompt = prompt;
            entry._response = response;
            entry._date = date; 

            return entry;
    }


    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public string LoadJournal()
    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        return fileName;
    }


    public void SaveEntry()
    {
        Console.Write("Which file do you want to save to? "); 
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}");
                outputFile.WriteLine($"Prompt: {entry._prompt}");
                outputFile.WriteLine($"Entry: {entry._response}");
                outputFile.WriteLine($"");
            }
        }
    }


    public string PickPrompt()
    {
        string fileName = "prompts.txt";
            string[] lines = File.ReadAllLines(fileName);
            
            int upperBound = lines.Count() - 1;
            Random rnd = new Random();
            int randInt = rnd.Next(upperBound);
            
            List <string> prompts = lines.ToList();
            string randPrompt = prompts[randInt];
            return randPrompt;
    }

    public void AddNewPrompt()
    {
        Console.WriteLine("What potential prompt would you like to add? ");
        string newPrompt = Console.ReadLine();
        File.AppendAllText("prompts.txt", newPrompt + Environment.NewLine);
    }
}

