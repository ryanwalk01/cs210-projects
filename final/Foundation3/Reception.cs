public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Reception, RSVP Email: {_rsvpEmail}");
    }

    public override void GetShortDescription()
    {
        Console.WriteLine($"Reception, {GetTitle()} {GetDate()}");
    }
}