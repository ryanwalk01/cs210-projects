public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() {
        _score = 0;
    }

    public void Start() {
        while (true) {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            int num;
            bool isNumber = int.TryParse(choice, out num);
            if (!isNumber || num > 6) {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            if (num == 1) {
                CreateGoal();
            }
            else if (num == 2) {
                ListGoalDetails();
            }
            else if (num == 3) {
                SaveGoals();
            }
            else if (num == 4) {
                LoadGoals();
            }
            else if (num == 5) {
                RecordEvent();
            }
            else {
                System.Environment.Exit(0);
            }
        }
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames() {
        int i = 1;
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals) {
            Console.WriteLine($"  {i}. {goal.GetName()}");
            i++;
        }
    }

    public void ListGoalDetails() {
        int i = 1;
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals) {
            Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal() {
        while (true) {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.WriteLine("  4. Habit Goal");
            
            Console.Write("Which type of goal would you like to create? ");
            int type = int.Parse(Console.ReadLine());
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (type == 1) {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
                break;
            }
            else if (type == 2 ) {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
                break;
            }
            else if (type == 3) {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
                break;
            }
            else if (type == 4) {
                HabitGoal goal = new HabitGoal(name, description, points);
                _goals.Add(goal);
                break;
            }
            else {
                Console.WriteLine("Invalid choice.");
                Thread.Sleep(250);
            }
        }
    }

    public void RecordEvent() {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goal = int.Parse(Console.ReadLine());
        int points = _goals[goal - 1].RecordEvent();

        if (points == 0) {
            Console.WriteLine("Goal already completed.");
        }
        else if (points < 0) {
            Console.WriteLine($"You lost {points * -1} points. Keep tying!");
            _score += points;
            Console.WriteLine($"You now have {_score} points.");
        }
        else {
            Console.WriteLine($"Congratulations! You have earned {points} points!");
            _score += points;
            Console.WriteLine($"You now have {_score} points.");
        }
    }

    public void SaveGoals() {
        Console.Write("What is filename for the goal file? ");
        string file = Console.ReadLine();

        using (StreamWriter outFile = new StreamWriter(file)) {
            outFile.WriteLine(_score);
            foreach (Goal goal in _goals) {
                outFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals() {
        Console.Write("What is filename for the goal file? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines) {
            string[] typePart = line.Split(":");
            string type = typePart[0];

            string[] goalParts = typePart[1].Split(",");

            string name = goalParts[0];
            string description = goalParts[1];
            int points = int.Parse(goalParts[2]);

            if (type == "SimpleGoal") {
                bool isComplete = bool.Parse(goalParts[3]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.setIsComplete(isComplete);
                _goals.Add(goal);
            }
            else if (type == "EternalGoal") {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "HabitGoal") {
                HabitGoal goal = new HabitGoal(name, description, points);
                _goals.Add(goal);
            }
            else {
                int completed = int.Parse(goalParts[4]);
                int target = int.Parse(goalParts[5]);
                int bonus = int.Parse(goalParts[3]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                goal.SetCompleted(completed);
                _goals.Add(goal);
            }
        }
    }
}