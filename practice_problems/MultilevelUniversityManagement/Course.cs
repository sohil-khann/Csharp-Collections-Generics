using System;
using System.Collections.Generic;

namespace UniversityCourseManagement
{
    public class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        public void DisplayAllCourses()
        {
            foreach (var course in courses)
            {
                course.DisplayEvaluationType();
            }
        }
    }
}
