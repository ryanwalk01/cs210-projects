// No duplicate prompts/questions are selected per session. Until the program is restarted, an activity becomes inaccessible after all prompts/questions for that activity have been used. 
public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _timesRun;

    public Activity() {
        _name = "Activity_name";
        _description = "Activity_description";
        _duration = 0;
        _timesRun = 0;
    }

    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds) {
        List<string> animationStrings = ["|", "/", "-", "\\", "|", "/", "-", "\\",];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime) {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i == animationStrings.Count) {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}