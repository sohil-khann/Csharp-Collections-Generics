using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamNormalization
{
    public class ExamNormalizer
    {
        // Subject -> List of Scores
        private Dictionary<string, List<int>> subjectScores = new Dictionary<string, List<int>>();
        private const int PassMark = 35;
        private const int MaxMark = 100;

        public void AddScores(string subject, List<int> scores)
        {
            if (scores == null || scores.Count == 0)
            {
                Console.WriteLine($"Warning: Empty score list for {subject}");
                return;
            }
            subjectScores[subject] = scores;
        }

        public void ProcessResults()
        {
            foreach (var subject in subjectScores.Keys.ToList())
            {
                Console.WriteLine($"\n--- Processing Subject: {subject} ---");
                List<int> scores = subjectScores[subject];

                // 1. Add Grace Marks (33-35 -> 35)
                for (int i = 0; i < scores.Count; i++)
                {
                    if (scores[i] >= 33 && scores[i] < PassMark)
                    {
                        Console.WriteLine($"  Grace marks added: {scores[i]} -> {PassMark}");
                        scores[i] = PassMark;
                    }
                }

                // 2. Normalize if class average < 50
                double average = scores.Average();
                Console.WriteLine($"  Current Average: {average:F2}");
                if (average < 50)
                {
                    Console.WriteLine("  Average below 50. Normalizing marks (+5 to everyone)...");
                    for (int i = 0; i < scores.Count; i++)
                    {
                        scores[i] = Math.Min(MaxMark, scores[i] + 5);
                    }
                }

                // 3. Recalculate Ranks using SortedDictionary
                // Key: Score (descending), Value: List of indices (students)
                // We use a custom comparer for descending order
                SortedDictionary<int, List<int>> rankMap = new SortedDictionary<int, List<int>>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

                for (int i = 0; i < scores.Count; i++)
                {
                    if (!rankMap.ContainsKey(scores[i]))
                    {
                        rankMap[rankMap.Keys.FirstOrDefault(k => k == scores[i])] = new List<int>(); // This is wrong, let's fix
                    }
                }
                // Let's rewrite the ranking logic properly
                rankMap.Clear();
                for (int i = 0; i < scores.Count; i++)
                {
                    if (!rankMap.ContainsKey(scores[i]))
                    {
                        rankMap[scores[i]] = new List<int>();
                    }
                    rankMap[scores[i]].Add(i);
                }

                Console.WriteLine("  Ranks:");
                int currentRank = 1;
                foreach (var entry in rankMap)
                {
                    foreach (var studentIndex in entry.Value)
                    {
                        Console.WriteLine($"    Student {studentIndex + 1}: Score {entry.Key}, Rank {currentRank}");
                    }
                    currentRank += entry.Value.Count;
                }

                // 4. Detect abnormal score inflation
                // Inflation if > 20% of students score > 90
                int highScorers = scores.Count(s => s > 90);
                if (scores.Count > 0 && (double)highScorers / scores.Count > 0.2)
                {
                    Console.WriteLine("  [ALERT] Abnormal score inflation detected! More than 20% students scored above 90.");
                }
            }
        }
    }
}