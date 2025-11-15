using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Library of sample scriptures
        var scriptures = new List<(Reference Ref, string Text)>
        {
            (new Reference("John", 3, 16),
             "For God so loved the world, that he gave his only begotten Son, " +
             "that whosoever believeth in him should not perish, but have everlasting life."),

            (new Reference("Proverbs", 3, 5, 6),
             "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
             "In all thy ways acknowledge him, and he shall direct thy paths."),

            (new Reference("Psalm", 23, 1),
             "The Lord is my shepherd; I shall not want.")
        };

        var rnd = new Random();

        while (true)
        {
            // Pick a random scripture from the library
            var pick = scriptures[rnd.Next(scriptures.Count)];
            var scripture = new Scripture(pick.Ref, pick.Text);

            // Memorization loop for this scripture
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.Write("Press ENTER to hide words, type 'next' for a new scripture, or 'quit' to exit: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }

                if (input.Trim().Equals("next", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Go to a new random scripture
                }

                // Hide a few random words
                scripture.HideRandomWords(3);

                // If all words are hidden, automatically move to the next scripture
                if (scripture.AllHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();
                    Console.WriteLine("You finished this scripture! Starting a new one...");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}