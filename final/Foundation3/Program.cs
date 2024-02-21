using System;
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Oak St", "Chicago", "IL", "USA");

        // Create events
        Event lecture = new Lecture("Public Speaking Seminar", "Learn the art of public speaking", new DateTime(2024, 2, 28), new TimeSpan(15, 0, 0), address1, "John Doe", 50);
        Event reception = new Reception("Networking Mixer", "Join us for a networking event", new DateTime(2024, 3, 15), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        Event gathering = new OutdoorGathering("Community Picnic", "Enjoy a day outdoors with your neighbors", new DateTime(2024, 4, 20), new TimeSpan(12, 0, 0), address3, "Sunny with a chance of clouds");

        // Display marketing messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(gathering.GetShortDescription());
    }
}