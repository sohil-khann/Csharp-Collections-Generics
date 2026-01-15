using System;

namespace ResumeScreening
{
    public class SoftwareEngineer : JobRole //class for software engineer
    {
        public SoftwareEngineer() : base("Software Engineer") { }
        public override string GetRequiredSkills() //overrided method
        {
            return "C#, .NET, SQL, JavaScript";
        }
    }
}
