public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Outdoor Gathering, Weather: {_weather}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Outdoor Gathering, {GetTitle()} {GetDate()}");
    }
}