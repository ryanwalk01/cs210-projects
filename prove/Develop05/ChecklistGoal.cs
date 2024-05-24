public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void SetCompleted(int completed) {
        _amountCompleted = completed;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target) {
            return _bonus;
        }
        else return _points;
    }

    public override bool isComplete()
    {
        if (_amountCompleted == _target) {
            return true;
        }
        else {
            return false;
        }
    }

    public override string GetDetailsString() {
        {
            bool complete = isComplete();
            string goal;
            if (complete)
            {
                goal = "X";
            }
            else
            {
                goal = " ";
            }
            return $"[{goal}]{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_amountCompleted},{_target}";
    }
}