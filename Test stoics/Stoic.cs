using Random_Stoic_quotes_generator;
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


public class RandomStoic
{
    public string Name { get; set; }

    public List<string> Quotes { get; set; }

    public RandomStoic(string name, string filePath)
    {
        Name = name;
        Quotes = new List<string>(File.ReadAllLines(filePath));
    }

    public string GetAnyRandomQuote()
    {
        Random rand = new Random();
        int index = rand.Next(Quotes.Count);
        return $"{Quotes[index]}";
    }
}