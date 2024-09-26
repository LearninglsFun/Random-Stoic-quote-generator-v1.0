using System;
using System.Collections.Generic;
using System.IO;

namespace Random_stoic_quotes_generator
{
    public class Stoic
    {
        public string Name { get; set; }
        public List<string> Quotes { get; set; }

        public Stoic(string name, string filePath)
        {
            Name = name;
            Quotes = new List<string>(File.ReadAllLines(filePath));
        }

        public string GetRandomQuote()
        {
            Random rand = new Random();
            int index = rand.Next(Quotes.Count);
            return $"{Quotes[index]} - {Name}";
        }
    }
}
