using System;
using System.Collections.Generic;

namespace Map
{
    public class WordFrequency
    {
        public static void Run()
        {
            string input = "Hello world, hello Java!";
            Console.WriteLine($"Input Text: \"{input}\"");

            // Split by non-word characters manually and filter out empty strings
            List<string> words = new List<string>();
            string lowerInput = input.ToLower();
            int start = 0;
            for (int i = 0; i < lowerInput.Length; i++)
            {
                if (!char.IsLetterOrDigit(lowerInput[i]))
                {
                    if (i > start)
                    {
                        words.Add(lowerInput.Substring(start, i - start));
                    }
                    start = i + 1;
                }
            }
            if (start < lowerInput.Length)
            {
                words.Add(lowerInput.Substring(start));
            }

            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (string.IsNullOrWhiteSpace(word)) continue;

                if (frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }

            Console.WriteLine("Word Frequencies:");//Print the word frequencies
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
