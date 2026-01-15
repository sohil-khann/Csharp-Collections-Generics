using System;
/*3. Multi-Level University Course Management System
 Concepts: Generic Classes, Constraints, Variance
 Problem Statement: Develop a university course management
system where different departments offer courses with different
evaluation types.
 Hints:
 Create an abstract class CourseType (e.g., ExamCourse,
AssignmentCourse).
 Implement a generic class Course<T> where T : CourseType
to manage different courses.
 Use List<T> to handle any type of course dynamically*/
 
namespace UniversityCourseManagement
{
    public static class CourseManagementMain
    {
        public static void Run()
        {

            // Exam courses
            Course<ExamCourse> examCourses = new Course<ExamCourse>();

            examCourses.AddCourse(new ExamCourse("Advanced Mathematics", 4, 120));

            examCourses.AddCourse(new ExamCourse("Physics I", 3, 90));

            // Assignment courses
            Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

            assignmentCourses.AddCourse(new AssignmentCourse("Software Engineering", 4, 5));

            assignmentCourses.AddCourse(new AssignmentCourse("Creative Writing", 2, 10));

            Console.WriteLine("Exam-based Courses:");
            examCourses.DisplayAllCourses();

            Console.WriteLine("\nAssignment-based Courses:");
            assignmentCourses.DisplayAllCourses();
            Console.WriteLine();
        }
    }
}
