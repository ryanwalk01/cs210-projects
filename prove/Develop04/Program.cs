using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        Console.WriteLine("Welcome to the Mindfulness Program!\n");

        while (true) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1") {
                breathingActivity.Run();
            }
            else if (choice == "2") {
                reflectingActivity.Run();
            }
            else if (choice == "3") {
                listingActivity.Run();
            }
            else {
                System.Environment.Exit(0);
            }
        }
    }
}