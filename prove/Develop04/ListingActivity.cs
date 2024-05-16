public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        // _prompts = ["Who are people that you appreciate?",
        //             "What are personal strengths of yours?",
        //             "Who are people that you have helped this week?",
        //             "When have you felt the Holy Ghost this month?",
        //             "Who are some of your personal heroes?",
        //             "What are some aspects of yourself that you are proud of?",
        //             "How have you positively impacted someone's life recently?"];
        _prompts = ["Who are people that you appreciate?"];
    }

    public void Run()
    {
        if (_prompts.Count == 0)
        {
            Console.WriteLine("\nSorry, there are no more prompts. Returning to menu...");
            ShowSpinner(5);
            Console.Clear();
        }
        else {
            DisplayStartingMessage();

            Console.WriteLine("List as many responds you can to the following prompt:");
            Console.WriteLine(GetRandomPrompt());
            Console.Write("\nYou may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();
            
            List<string> input = GetListFromUser();

            Console.WriteLine($"You listed {_count} items!");

            DisplayEndingMessage();
        }
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int number = rnd.Next(0, _prompts.Count);
        string prompt = _prompts[number];
        _prompts.RemoveAt(number);

        return prompt;
    }

    public List<string> GetListFromUser() {
        List<string> strings = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            strings.Add(input);
            _count += 1;
        }
        return strings;
    }
}