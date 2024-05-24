public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void setIsComplete(bool isComplete) {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete) {
            return 0;
        }
        else {
            _isComplete = true;
            return _points;
        }
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}