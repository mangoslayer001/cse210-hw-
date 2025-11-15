using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Library of sample scriptures to slightly exceed requirements
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
        var pick = scriptures[rnd.Next(scriptures.Count)];
        var scripture = new Scripture(pick.Ref, pick.Text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press ENTER to hide words or type quit: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Hide a few words per step
            scripture.HideRandomWords(3);

            if (scripture.AllHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Program will end.");
                break;
            }
        }
    }
}

/*
Exceeding requirements notes

1) Chooses only visible words to hide each step, which avoids wasting turns on already hidden words.
2) Preserves punctuation while masking only letters, which makes the display clearer during memorization.
3) Includes a small library of scriptures and selects one at random at startup.
*/
