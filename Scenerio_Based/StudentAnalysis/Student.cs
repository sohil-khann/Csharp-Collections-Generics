namespace StudentAnalysis
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int ConsecutiveFailures { get; set; }

        public Student(int rollNo, string name)
        {
            RollNo = rollNo;
            Name = name;
            ConsecutiveFailures = 0;
        }
    }
}
