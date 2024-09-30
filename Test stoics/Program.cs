using Random_Stoic_quotes_generator;

class Program
{
    static void Main(string[] args)
    {
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



        while (true)
        {
            Console.WriteLine("Choose a Stoic philosopher to generate quotes:");
            foreach (var stoic in stoics)
            {
                Console.WriteLine($"{stoic.Key}: {stoic.Value.Name}");
            }
            Console.WriteLine("9: Random quote from all Stoics");

            int choice;
            string input = Console.ReadLine();

            if (input == "9")
            {
                Console.Clear();
                Console.WriteLine(Stoic.RandomQuote(stoics));
                Console.WriteLine("");
                Console.WriteLine("Do you wish to get more random quotes or select a new Stoic?");
                Console.WriteLine("For more quotes press enter or type 'new'.");

                while (true)
                {
                    string userChoice = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(userChoice))
                    {
                        Console.Clear();
                        Console.WriteLine(Stoic.RandomQuote(stoics));
                        Console.WriteLine("\nFor more quotes press enter or type 'new'.");
                        continue;
                    }
                    else if (userChoice == "new")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'new' or press enter for more quotes.");
                    }
                }
            }
            else if (string.IsNullOrEmpty(input) || !int.TryParse(input, out choice) || !stoics.ContainsKey(choice))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                Console.WriteLine("");
                continue;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(stoics[choice].GetRandomQuote());
                Console.WriteLine("");
                Console.WriteLine("Do you wish to get more random quotes or select a new Stoic?");
                Console.WriteLine("For more quotes press enter or type 'new'.");

                while (true)
                {
                    string userChoice = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(userChoice))
                    {
                        Console.Clear();
                        Console.WriteLine(stoics[choice].GetRandomQuote());
                        Console.WriteLine("\nFor more quotes press enter or type 'new'.");
                        continue;
                    }
                    else if (userChoice == "new")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'new' or press enter.");
                    }
                }
            }
        }
    }
}