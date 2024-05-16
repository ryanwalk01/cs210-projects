using System.Net;

public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilence.";
        _prompts = ["Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless.",
                    "Think of a time when you faced a major setback but managed to turn it into a valuable learning experience.",
                    "Think of a time when you took a risk that ultimately led to a positive outcome.",
                    "Think of a time when you had to navigate a challenging conflict and found a peaceful resolution."];
        
        _questions = ["Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"];
    }

    public void Run()
    {
        if (_prompts.Count == 0) {
            Console.WriteLine("\nSorry, there are no more prompts. Returning to menu...");
            ShowSpinner(5);
            Console.Clear();
        }
        else if (_questions.Count == 0) {
            Console.WriteLine("\nSorry, there are no more questions. Returning to menu...");
            ShowSpinner(5);
            Console.Clear();
        }
        else {
            DisplayStartingMessage();

            Console.WriteLine("Consider the following prompt:");
            DisplayPrompt();

            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                DisplayQuestion();
                ShowSpinner(5);
            }

            DisplayEndingMessage();
        }
    }

    public string GetRandomPrompt() {
        Random rnd = new Random();
        int number = rnd.Next(0, _prompts.Count);

        return _prompts[number];
    }

    public string GetRandomQuestion() {
        Random rnd = new Random();
        int number = rnd.Next(0, _questions.Count);
        string question = _questions[number];
        _questions.RemoveAt(number);
        return question;
    }

    public void DisplayPrompt() {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---- {prompt} -----");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question}");
    }
}