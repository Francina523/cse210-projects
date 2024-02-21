// Derived Reception class
public class Reception : Event
{
    private string RsvpEmail { get; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nRSVP Email: {RsvpEmail}";
    }
}
