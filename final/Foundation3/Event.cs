public abstract class Event {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle() {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public void GetStandardDetails() {
        Console.WriteLine($"{_title} ({_description})\n{_date} {_time}\n{_address.GetAddress()}");
    }

    public abstract void GetFullDetails();
    
    public abstract void GetShortDescription();
}