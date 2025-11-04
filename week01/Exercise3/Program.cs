using System;

class Program
{
    static void Main(string[] args)
    {
        
        var rng = new Random();

        while (true)
        {
            int magic = rng.Next(1, 101);
            int attempts = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (true)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Please enter a whole number.");
                    continue;
                }

                attempts++;

                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} guess{(attempts == 1 ? "" : "es")}.");
                    break;
                }
            }

            Console.Write("Play again? (yes/no) ");
            string again = (Console.ReadLine() ?? "").Trim().ToLower();
            if (again != "y" && again != "yes") break;
            Console.WriteLine();
        }
    }
}