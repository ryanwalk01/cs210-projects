using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        Journal journal = new Journal();

        // Prompt List
        prompts._prompts = new List<string> {
            "What are you grateful for?",
            "What did you learn today?",
            "What was something nice that you did for someone or someone did for you?",
            "What inspired you today?",
            "What is something you worked on or accomplished today?"};

        while (true)
        {
            int x = 0;
            if (x == 0)
            {
                Console.WriteLine("Welcome to Ryan's Journal Program!");
                x += 1;
            }

            Console.WriteLine("\nSelect one of the following options via its number:");

            Console.WriteLine("1: New Entry");
            Console.WriteLine("2: Display All Entries");
            Console.WriteLine("3: Save to File");
            Console.WriteLine("4: Load from File");
            Console.WriteLine("5: Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // New Entry
                case 1:
                    Entry entry = new Entry();

                    DateTime currentTime = DateTime.Now;
                    string date = currentTime.ToShortDateString();

                    entry._date = date;
                    entry._promptText = prompts.GetRandomPrompt();

                    Console.WriteLine("\nPlease press enter when finished writing.\n");
                    Console.WriteLine(entry._date);
                    Console.WriteLine(entry._promptText);
                    entry._entryText = Console.ReadLine();

                    Console.WriteLine("Saving...");
                    journal.AddEntry(entry);
                    Console.WriteLine("Saved.");

                    break;

                // Display all entries
                case 2:
                    journal.DisplayAll();

                    Console.WriteLine("Please enter when finished");
                    Console.ReadLine();
                    break;

                // Save to File
                case 3:
                    Console.WriteLine("What filename would you like to use to save your journal?");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                // Load File
                case 4:
                    Console.WriteLine("What is the name of the file you would like to load?");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                // Quit
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}