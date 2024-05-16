public class BreathingActivity : Activity {

    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public void Run() {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) {
        Console.Write("Breathe in...");
        ShowCountDown(5);

        Console.Write("\nNow breathe out...");
        ShowCountDown(5);
        
        Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}