using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("5/30/2024", 30, 3);
        Cycling cycling = new Cycling("5/29/2024", 30, 7);
        Swimming swimming = new Swimming("5/28/2024", 5, 10);

        List<Activity> activities = new List<Activity> {running, cycling, swimming};
        
        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}