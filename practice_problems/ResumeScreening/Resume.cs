using System;

namespace ResumeScreening
{
    public class Resume<T> where T : JobRole // class for Resume
    {
        public string CandidateName { get; set; }
        public T TargetRole { get; set; }

        public Resume(string name, T role) //constructor
        {
            CandidateName = name;
            TargetRole = role;
        }

        public void DisplayResumeInfo()//display method
        {
            Console.WriteLine($"Candidate: {CandidateName} | Role: {TargetRole.RoleName} | Skills: {TargetRole.GetRequiredSkills()}");
        }
    }
}
