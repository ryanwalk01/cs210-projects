public class HabitGoal : Goal
{

    public HabitGoal(string name, string description, int points) : base(name, description, points)
    {
        if (_points > 0) {
            _points *= -1;
        }
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"HabitGoal:{_shortName},{_description},{_points}";
    }
}