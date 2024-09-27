using Random_Stoic_quotes_generator;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary to hold the stoics and their quotes
        Dictionary<int, Stoic> stoics = new Dictionary<int, Stoic>()
        {
            {1, new Stoic("Marcus Aurelius", @"Quotes\Marcus Aurelius quotes.txt") },
            {2, new Stoic("Cato The Younger", @"Quotes\Cato The Younger quotes.txt") },
            {3, new Stoic("Diogenes", @"Quotes\Diogenes quotes.txt") },
            {4, new Stoic("Epictetus", @"Quotes\Epictetus quotes.txt") },
            {5, new Stoic("Seneca", @"Quotes\Seneca quotes.txt") },
            {6, new Stoic("Musonius Rufus", @"Quotes\Musonius Rufus quotes.txt") },
            {7, new Stoic("Marcus Tullius Cicero", @"Quotes\Marcus Tullius Cicero quotes.txt") },
            {8, new Stoic("Zeno", @"Quotes\Zeno quotes.txt") },
        };

        Dictionary<int, RandomStoic> randomStoic = new Dictionary<int, RandomStoic>()
        {
             {9, new RandomStoic("Random quote", @"Quotes\All quotes.txt") }
        };

        while (true)
        {
            // User will choose which stoic to get quotes from
            Console.WriteLine("Choose a Stoic philosopher to generate quotes:");
            foreach (var stoic in stoics)
            {
                Console.WriteLine($"{stoic.Key}: {stoic.Value.Name}");
            }
            foreach (var randomstoic in randomStoic)
            {
                Console.WriteLine($"{randomstoic.Key}: {randomstoic.Value.Name}");
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

                if (input == "9")
                {
                    Console.Clear();
                    Console.WriteLine(randomStoic[9].GetAnyRandomQuote());
                    Console.WriteLine("");
                    Console.WriteLine("Do you wish to get more random quotes or select a new Stoic?");
                    Console.WriteLine("Please enter: 'same' or 'new'. ");

                    while (true)
                    {
                        string userChoice = Console.ReadLine().ToLower();

                        if (userChoice == "new")
                        {
                            Console.Clear();
                            Console.WriteLine("Choose a Stoic philosopher to generate quotes:");
                            foreach (var stoic in stoics)
                            {
                                Console.WriteLine($"{stoic.Key}: {stoic.Value.Name}");
                            }
                            foreach (var randomstoic in randomStoic)
                            {
                                Console.WriteLine($"{randomstoic.Key}: {randomstoic.Value.Name}");
                            }
                            break; // Exit the loop to select a new Stoic
                        }
                        else if (userChoice == "same")
                        {
                            Console.Clear();
                            Console.WriteLine(randomStoic[9].GetAnyRandomQuote());
                            Console.WriteLine("");
                            Console.WriteLine("Do you wish to get more random quotes or select a new Stoic?");
                            Console.WriteLine("Please enter: 'same' or 'new'.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter: 'same' or 'new'.");
                        }
                    }
                }
                else if (int.TryParse(input, out choice) && stoics.ContainsKey(choice))
                {
                    break; // Valid choice made, exits the loop
                }
                else
                {
                    Console.WriteLine("Philosopher not found. Please enter a valid number.");
                }
            }

            // Clear the console and show a random quote
            Console.Clear();
            Console.WriteLine(stoics[choice].GetRandomQuote());
            Console.WriteLine("");
            Console.WriteLine("Do you wish to generate another quote by the same Stoic or choose a new Stoic?");
            Console.WriteLine("Please enter: 'same' or 'new'.");

            // To generate a new quote from the same Stoic press enter or type new to choose a new Stoic.
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
                    Console.WriteLine("");
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
