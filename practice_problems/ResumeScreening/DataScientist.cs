using System;

namespace ResumeScreening
{
    public class DataScientist : JobRole //class for datascientist role
    {
        public DataScientist() : base("Data Scientist") { }
        public override string GetRequiredSkills() //overrided method
        {
            return "Python, R, Machine Learning, Statistics";
        }
    }
}
