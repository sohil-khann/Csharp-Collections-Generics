using System;

namespace UniversityCourseManagement
{
    public class AssignmentCourse : CourseType
    {
        public int NumberOfAssignments { get; set; }

        public AssignmentCourse(string title, int credits, int assignments) : base(title, credits)
        {
            NumberOfAssignments = assignments;
        }

        public override void DisplayEvaluationType()
        {
            Console.WriteLine($"Assignment Course: {Title} ({Credits} credits) - Assignments: {NumberOfAssignments}");
        }
    }
}
