 
 using System;
 /*
PROBLEM STATEMENT 1: Student Performance Analyzer
Create a C# program to analyze student performance. Each student appears for multiple subjects. 
Store: 
- Student details in a List 
- Marks in a Dictionary<int, List<int>> (RollNo -> Marks) 

Tasks:
1. Calculate average marks for each student. 
2. A student passes if: 
   - Average >= 40 
   - No subject mark < 30 
3. Display: 
   - Students who passed overall but failed in at least one subject 
   - Top scorer of each subject 
4. Remove students who failed 3 consecutive exams. 

Edge Cases:
- Student with no marks recorded 
- Marks exactly 30 or 40 
- Subjects count differs per student 
- Removing items while iterating a collection 
- Duplicate roll numbers*/
 namespace StudentAnalysis{
    public class StudentMain{ // main class 
  public static void RunStudentPerformanceAnalyzer()//method to run the program
        {
            PerformanceAnalyzer analyzer = new PerformanceAnalyzer();

            analyzer.AddStudent(101, "Amit", new List<int> { 45, 50, 25 }); //entries
            analyzer.AddStudent(102, "Sita", new List<int> { 35, 30, 40 });
            analyzer.AddStudent(103, "Rahul", new List<int> { 60, 70, 80, 90 });
            analyzer.AddStudent(104, "Priya", new List<int> { 40, 40, 40 });
            analyzer.AddStudent(105, "Vikram", new List<int>());
            
            analyzer.Analyze();

            List<int> failedThisTime = new List<int> { 101, 102, 105 };//failed student
            Console.WriteLine("\nSimulating 3 consecutive failures...");
            analyzer.RemoveConsecutiveFailures(failedThisTime);
            analyzer.RemoveConsecutiveFailures(failedThisTime);
            analyzer.RemoveConsecutiveFailures(failedThisTime);
        }
 }
 }