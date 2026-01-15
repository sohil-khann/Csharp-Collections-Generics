using System;
using System.Collections.Generic;

namespace ResumeScreening
{
    public static class ResumeScreeningMain //main class
    {
        public static void Run() //main method
        {

//Resume for software engineer
            List<Resume<SoftwareEngineer>> devResumes = new List<Resume<SoftwareEngineer>>
            {
                new Resume<SoftwareEngineer>("Sohil", new SoftwareEngineer()),
                new Resume<SoftwareEngineer>("Raj", new SoftwareEngineer())
            };
//Resume for Data scientist
            List<Resume<DataScientist>> dsResumes = new List<Resume<DataScientist>>
            {
                new Resume<DataScientist>("Charan", new DataScientist()),
                new Resume<DataScientist>("Ravi", new DataScientist())
            };

            Console.WriteLine("Processing Software Engineer Resumes:");
            foreach (var r in devResumes) r.DisplayResumeInfo(); //for iterating in list

            Console.WriteLine("\nProcessing Data Scientist Resumes:");
            foreach (var r in dsResumes) r.DisplayResumeInfo(); //for iterating in list
            Console.WriteLine();
        }
    }
}
