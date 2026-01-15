using System;

namespace UniversityCourseManagement
{
    public class ExamCourse : CourseType
    {
        public int ExamDurationMinutes { get; set; }

        public ExamCourse(string title, int credits, int duration) : base(title, credits)
        {
            ExamDurationMinutes = duration;
        }

        public override void DisplayEvaluationType()
        {
            Console.WriteLine($"Exam Course: {Title} ({Credits} credits) - Exam Duration: {ExamDurationMinutes} mins");
        }
    }
}
