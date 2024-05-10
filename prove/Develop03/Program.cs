// To help with memorizing the scripture, I added an option to show the first letter of hidden words.
using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Would you like to see the first letters of hidden words? (Yes/No)");
        string userInput = Console.ReadLine();
        bool showFirstLetter = false;

        if (userInput.ToLower() == "yes") {
            showFirstLetter = true;
        }

        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",showFirstLetter);

        Console.WriteLine();
    do {
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
        string quit = Console.ReadLine();

        if (quit == "quit") {
            break;
        }

        if (scripture.IsCompletelyHidden()) {
            Console.WriteLine("All words are hidden. Exiting...");
            break;
        }

        scripture.HideRandomWords(3);
        Console.Clear();
        } 
        while (true);
    }
}