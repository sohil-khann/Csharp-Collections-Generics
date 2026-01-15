using System;

namespace ResumeScreening
{
    public abstract class JobRole // abstract class of jobrole
    {
        public string RoleName { get; set; }
        public abstract string GetRequiredSkills();

        protected JobRole(string roleName)//constructor
        {
            RoleName = roleName;
        }
    }
}
