using System;

namespace UniversityCourseManagement
{
    public abstract class CourseType
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        protected CourseType(string title, int credits)
        {
            Title = title;
            Credits = credits;
        }

        public abstract void DisplayEvaluationType();
    }
}
