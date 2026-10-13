namespace journal; 
using System;


class Program
{
    static void Main(string[] args)
    {
        string command = "";

        Journal journals = new Journal();

        string fileName = "";

        
        while (command != "7")
        {
            Console.WriteLine("""Please select one of the following choices:""");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Add new prompt");
            Console.WriteLine("6. Unload file");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do? ");
            command = Console.ReadLine();
            Console.WriteLine("");


            //command to write a new entry and add to the _entries list of the Journal class object
            if (command == "1")
            {
                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;

                string prompt = journals.PickPrompt(); 
                string response;
                string date = currentTime.ToShortDateString();

                Console.WriteLine(prompt); 
                response = Console.ReadLine();

                entry._prompt = prompt;
                entry._response = response;
                entry._date = date;

                journals._entries.Add(entry);
            }

            //display all of the information of the currently written entries/entries in 
            // a file?
            else if (command == "2")
            {

                if (fileName != "")
                {
                    string[] lines = File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                        Console.WriteLine("");

                }
                else
                {
                    foreach (Entry entry in journals._entries)
                    {
                        entry.Display();
                }
                }
            }

            //the load command to open up the desired file
            else if (command == "3")
            {
                fileName = journals.LoadJournal();
            }

            //command to write the new entries to a designated file
            else if (command == "4")
            {
                journals.SaveEntry();
            }

            //command to write a new prompt to the prompts.txt file
            else if (command == "5")
            {
                journals.AddNewPrompt();
            }

            else if (command == "6")
            {
                fileName = "";
            }
            
        }
    }
}