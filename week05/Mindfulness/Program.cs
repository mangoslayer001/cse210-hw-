using System;
using System.Collections.Generic;

class Program
{
    // Exceeding Requirements:
    // - Track how many activities the user completes in this session
    //   and show a small summary when they quit.

    static void Main(string[] args)
    {
        int totalActivitiesRun = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                totalActivitiesRun++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                totalActivitiesRun++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                totalActivitiesRun++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program.");
                Console.WriteLine($"You completed {totalActivitiesRun} activities this session.");
                Console.WriteLine("\nPress enter to exit...");
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to try again.");
                Console.ReadLine();
            }
        }
    }
}
