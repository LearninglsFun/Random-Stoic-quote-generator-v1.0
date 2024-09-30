namespace Random_Stoic_quotes_generator
{
    public class Stoic
    {
        public string Name { get; set; }
        public List<string> Quotes { get; set; }

        public string AddQuotes { get; set; }

        public Stoic(string name, string filePath)
        {
            Name = name;

            // Combine the base directory with the relative path to ensure correct file access
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", filePath);
            Quotes = new List<string>(File.ReadAllLines(fullPath));

        }

        public static string RandomQuote(Dictionary<int, Stoic> stoics)
        {
            Random rand = new Random();
            var allQuotes = new List<string>();

            foreach (var stoic in stoics.Values)
            {
                foreach (var quote in stoic.Quotes)
                {
                    allQuotes.Add($"{quote} - {stoic.Name}");
                }
            }
            int index = rand.Next(allQuotes.Count);
            return allQuotes[index];
        }

        public string GetRandomQuote()
        {
            Random rand = new Random();
            int index = rand.Next(Quotes.Count);
            return $"{Quotes[index]} - {Name}";
        }
    }
}