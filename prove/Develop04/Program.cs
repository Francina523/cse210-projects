using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an Activity");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunActivity(new BreathingActivity(60, "This activity will help you relax by walking your through breathing in and out slowly."));
                    break;
                case "2":
                    RunActivity(new ReflectionActivity(90, "This activity will help you reflect on times in your life when you have shown strength and resilience."));
                    break;
                case "3":
                    RunActivity(new ListingActivity(120, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."));
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }
        }
    }

    static void RunActivity(MindfulnessActivity activity)
    {
        activity.Start();
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}