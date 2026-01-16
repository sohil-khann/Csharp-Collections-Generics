using System;
using System.Collections.Generic;

namespace Queue
{
    public class HospitalTriage
    {
        private class MaxComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }

        public static void Run()
        {
            // PriorityQueue is a min-priority queue by default. 
            // To treat it as max-priority (higher severity first), we use a custom comparer.
            PriorityQueue<string, int> triage = new PriorityQueue<string, int>(new MaxComparer());

            triage.Enqueue("Sohil", 3);
            triage.Enqueue("Raj", 5);
            triage.Enqueue("Ravi", 2);

            Console.WriteLine("Treating patients in order of severity:");
            while (triage.Count > 0)
            {
                if (triage.TryDequeue(out string? patient, out int priority))
                {
                    Console.WriteLine($"Patient: {patient}, Severity: {priority}");
                }
            }
        }
    }
}
