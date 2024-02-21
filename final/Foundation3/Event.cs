// Base Event class
public class Event
{
    private string EventTitle { get; }
    private string Description { get; }
    private DateTime Date { get; }
    private TimeSpan Time { get; }
    private Address Address { get; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        EventTitle = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {EventTitle}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nEvent Title: {EventTitle}\nDate: {Date.ToShortDateString()}";
    }
}

