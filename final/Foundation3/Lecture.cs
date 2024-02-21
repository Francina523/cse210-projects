// Derived Lecture class
public class Lecture : Event
{
    private string SpeakerName { get; }
    private int Capacity { get; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nSpeaker: {SpeakerName}\nCapacity: {Capacity}";
    }
}