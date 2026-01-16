using System;
using System.Collections.Generic;

namespace Map
{
    public class InvertMap//For invert the map
    {
        public static void Run()
        {
            Dictionary<string, int> input = new Dictionary<string, int>//input is {A=1, B=2, C=1}
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

            Console.WriteLine("Original Map:");
            foreach (var kvp in input)//Print the original map
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }

            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();//inverted is {1=[A, C], 2=[B]}

            foreach (var kvp in input)//Invert the map
            {
                if (!inverted.ContainsKey(kvp.Value))
                {
                    inverted[kvp.Value] = new List<string>();
                }
                inverted[kvp.Value].Add(kvp.Key);
            }

            Console.WriteLine("\nInverted Map:");
            foreach (var kvp in inverted)//Print the inverted map
            {
                Console.WriteLine($"{kvp.Key} = [{string.Join(", ", kvp.Value)}]");
            }
        }
    }
}
