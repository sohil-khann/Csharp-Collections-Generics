using System;
using System.Collections.Generic;

namespace ExamNormalization
{
    public class ExamNormalizationMain
    {
        public static void RunExamNormalizationSystem()
        {
            Console.WriteLine("--- Online Exam Result Normalization System ---");
            ExamNormalizer normalizer = new ExamNormalizer();

            // Case 1: Low average subject (needs normalization)
            normalizer.AddScores("Mathematics", new List<int> { 33, 45, 20, 34, 40, 42, 38 });

            // Case 2: Subject with inflation
            normalizer.AddScores("History", new List<int> { 91, 92, 93, 40, 50, 60 });

            // Case 3: Empty subject list (Edge case)
            normalizer.AddScores("Physics", new List<int>());

            // Case 4: Scores exceeding limits (handled in normalization logic)
            normalizer.AddScores("Chemistry", new List<int> { 98, 99, 100 });

            normalizer.ProcessResults();
        }
    }
}