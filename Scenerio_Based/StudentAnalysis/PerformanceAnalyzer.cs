using System;
using System.Collections.Generic;

namespace StudentAnalysis
{
    public class PerformanceAnalyzer
    {
        private List<Student> students;
        private Dictionary<int, List<int>> marksData;

        public PerformanceAnalyzer()
        {
            students = new List<Student>();
            marksData = new Dictionary<int, List<int>>();
        }

        public void AddStudent(int rollNo, string name, List<int> marks)
        {
            // Check for duplicate roll number
            bool exists = false;
            foreach (var s in students)
            {
                if (s.RollNo == rollNo)
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                students.Add(new Student(rollNo, name));
                marksData[rollNo] = marks;
            }
            else
            {
                Console.WriteLine("Student with Roll No " + rollNo + " already exists.");
            }
        }

        public void Analyze()
        {
            Console.WriteLine("\n--- Student Performance Analysis ---");

            // 1. Calculate and display average for each student
            foreach (var student in students)
            {
                if (marksData.ContainsKey(student.RollNo))
                {
                    List<int> marks = marksData[student.RollNo];
                    double average = CalculateAverage(marks);
                    bool isPass = CheckIfPassed(marks, average);

                    Console.WriteLine("Student: " + student.Name + " (Roll: " + student.RollNo + ")");
                    Console.WriteLine("  Average: " + average.ToString("F2"));
                    Console.WriteLine("  Status: " + (isPass ? "Passed" : "Failed"));
                }
                else
                {
                    Console.WriteLine("Student: " + student.Name + " (Roll: " + student.RollNo + ") has no marks recorded.");
                }
            }

            // 3. Display students who passed overall but failed in at least one subject
            Console.WriteLine("\nStudents who passed overall (Avg >= 40) but failed in at least one subject (Mark < 30):");
            bool foundSpecial = false;
            foreach (var student in students)
            {
                if (marksData.ContainsKey(student.RollNo))
                {
                    List<int> marks = marksData[student.RollNo];
                    double average = CalculateAverage(marks);
                    
                    bool passedOverall = average >= 40;
                    bool failedOneSubject = false;
                    foreach (int m in marks)
                    {
                        if (m < 30)
                        {
                            failedOneSubject = true;
                            break;
                        }
                    }

                    if (passedOverall && failedOneSubject)
                    {
                        Console.WriteLine("- " + student.Name);
                        foundSpecial = true;
                    }
                }
            }
            if (!foundSpecial) Console.WriteLine("None found.");

            // 3. Top scorer of each subject
            FindTopScorers();
        }

        private double CalculateAverage(List<int> marks)
        {
            if (marks == null || marks.Count == 0) return 0;
            int total = 0;
            foreach (int m in marks)
            {
                total += m;
            }
            return (double)total / marks.Count;
        }

        private bool CheckIfPassed(List<int> marks, double average)
        {
            if (marks == null || marks.Count == 0) return false;
            if (average < 40) return false;

            foreach (int m in marks)
            {
                if (m < 30) return false;
            }
            return true;
        }

        private void FindTopScorers()
        {
            Console.WriteLine("\nTop Scorer for Each Subject:");
            
            // Find max subjects count across all students
            int maxSubjects = 0;
            foreach (var marks in marksData.Values)
            {
                if (marks.Count > maxSubjects) maxSubjects = marks.Count;
            }

            for (int i = 0; i < maxSubjects; i++)
            {
                int maxMark = -1;
                string topStudent = "N/A";

                foreach (var student in students)
                {
                    if (marksData.ContainsKey(student.RollNo))
                    {
                        List<int> marks = marksData[student.RollNo];
                        if (i < marks.Count)
                        {
                            if (marks[i] > maxMark)
                            {
                                maxMark = marks[i];
                                topStudent = student.Name;
                            }
                        }
                    }
                }
                Console.WriteLine("Subject " + (i + 1) + ": " + topStudent + " with " + maxMark + " marks");
            }
        }

        public void RemoveConsecutiveFailures(List<int> failedRolls)
        {
            // The problem mentions "failed 3 consecutive exams"
            // Since we only have one set of marks here, let's assume this method 
            // is called repeatedly or we simulate the "consecutive" logic.
            // For the purpose of this demo, I'll add a property to Student to track history.
            
            Console.WriteLine("\nRemoving students who failed 3 consecutive times...");

            // Logic: Iterate through all students, check if they are in the failed list.
            // If they are, increment consecutive failures. If not, reset to 0.
            // Then remove those with 3.

            for (int i = students.Count - 1; i >= 0; i--)
            {
                Student s = students[i];
                bool failedThisTime = false;
                foreach (int roll in failedRolls)
                {
                    if (roll == s.RollNo)
                    {
                        failedThisTime = true;
                        break;
                    }
                }

                if (failedThisTime)
                {
                    s.ConsecutiveFailures++;
                }
                else
                {
                    s.ConsecutiveFailures = 0;
                }

                if (s.ConsecutiveFailures >= 3)
                {
                    Console.WriteLine("Removing " + s.Name + " (Roll: " + s.RollNo + ") for 3 consecutive failures.");
                    marksData.Remove(s.RollNo);
                    students.RemoveAt(i);
                }
            }
        }
    }
}
