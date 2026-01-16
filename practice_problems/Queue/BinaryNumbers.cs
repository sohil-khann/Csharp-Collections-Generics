using System;
using System.Collections.Generic;

namespace Queue
{
    public class BinaryNumbers
    {
        public static void Run()
        {
            int n = 5;
            Console.WriteLine($"Generating first {n} binary numbers:");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");

            List<string> result = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                result.Add(current);

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            Console.WriteLine($"Result: {{{string.Join(", ", result)}}}");
        }
    }
}
