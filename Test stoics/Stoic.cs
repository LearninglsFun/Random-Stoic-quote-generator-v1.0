using System;
using System.Collections.Generic;
using System.IO;

namespace Random_Stoic_quotes_generator
{
    public class Stoic
    {
        public string Name { get; set; }
        public List<string> Quotes { get; set; }

        public Stoic(string name, string filePath)
        {
            Name = name;

            // Combine the base directory with the relative path to ensure correct file access
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", filePath);
            Quotes = new List<string>(File.ReadAllLines(fullPath)); // Use fullPath here
        }

        public string GetRandomQuote()
        {
            Random rand = new Random();
            int index = rand.Next(Quotes.Count);
            return $"{Quotes[index]} - {Name}";
        }
    }

    public class RandomStoic
    {
        public string Name { get; set; }
        public List<string> Quotes { get; set; }

        public RandomStoic(string name, string filePath)
        {
            Name = name;

            // Combine the base directory with the relative path to ensure correct file access
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", filePath);
            Quotes = new List<string>(File.ReadAllLines(fullPath)); // Use fullPath here
        }

        public string GetAnyRandomQuote()
        {
            Random rand = new Random();
            int index = rand.Next(Quotes.Count);
            return $"{Quotes[index]}";
        }
    }
}
