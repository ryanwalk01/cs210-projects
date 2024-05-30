using System;

class Program
{
    static void Main(string[] args)
    {
       Address address1 = new Address("532 S 2nd E", "Rexburg", "ID", "USA");
       Address address2 = new Address("68 E 7th S", "Rexburg", "ID", "USA");
       Address address3 = new Address("S 2nd W & 3rd W", "Rexburg", "ID", "USA");

       Lecture lecture = new Lecture("Calculus", "Lecture on calculus.", "6/10/2024", "9:00am", address1, "Brother Martin", 40);
       Reception reception = new Reception("Wedding Reception", "Wedding reception for Marc & Hailey", "7/20/2024", "7:00pm", address2, "marcr@gmail.com");
       Outdoor outdoor = new Outdoor("Game Fest", "Summer game fest at Porter Park", "6/15/2024", "10:00am", address3, "Clear skies, high of 82°");

       List<Event> events = new List<Event> {lecture, reception, outdoor};

       foreach (Event e in events) {
            e.GetStandardDetails();
            Console.WriteLine();
            e.GetFullDetails();
            Console.WriteLine();
            e.GetShortDescription();
            Console.WriteLine();
       }
    }
}