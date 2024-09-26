using Random_stoic_quotes_generator;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary to hold the stoics and their quotes
        Dictionary<int, Stoic> stoics = new Dictionary<int, Stoic>()
        {
            {1, new Stoic("Marcus Aurelius", "Marcus Aurelius quotes.txt") },
            {2, new Stoic("Cato The Younger", "Cato The Younger quotes.txt") },
            {3, new Stoic("Diogenes", "Diogenes quotes.txt") },
            {4, new Stoic("Epictetus", "Epictetus quotes.txt") },
            {5, new Stoic("Seneca", "Seneca quotes.txt") },
            {6, new Stoic("Musonius Rufus", "Musonius Rufus quotes.txt") },
            {7, new Stoic("Marcus Tullius Cicero", "Marcus Tullius Cicero quotes.txt") },
            {8, new Stoic("Zeno", "Zeno quotes.txt") }
        };

        while (true)
        {
            // User will choose which stoic to get quotes from
            Console.WriteLine("Choose a Stoic philosopher to generate quotes:");
            foreach (var stoic in stoics)
            {
                Console.WriteLine($"{stoic.Key}: {stoic.Value.Name}");
            }

            int choice;
            // Loop until a valid choice is made
            while (true)
            {
                string input = Console.ReadLine();

                // Check if input is empty and prompt again
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                
                if (int.TryParse(input, out choice) && stoics.ContainsKey(choice))
                {
                    break; // Valid choice made, exits the loop
                }
                else
                {
                    Console.WriteLine("Philosopher not found. Please enter a valid number:");
                }
            }

            // Clear the console and show a random quote
            Console.Clear();
            Console.WriteLine(stoics[choice].GetRandomQuote());
            Console.WriteLine();
            Console.WriteLine("Do you wish to generate another quote by the same Stoic or choose a new Stoic?");
            Console.WriteLine("Please enter: 'same' or 'new'.");

            while (true)
            {
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "new")
                {
                    Console.Clear();
                    break; // Exit the loop to select a new Stoic
                }
                else if (userChoice == "same")
                {
                
                    Console.Clear();
                    Console.WriteLine(stoics[choice].GetRandomQuote());
                    Console.WriteLine();
                    Console.WriteLine("Do you wish to generate another quote by the same Stoic or choose a new Stoic?");
                    Console.WriteLine("Please enter: 'same' or 'new'.");
                }
                else
                {
                   
                    Console.WriteLine("Invalid choice. Please enter: 'same' or 'new'.");
                }
            }
        }
    }
}