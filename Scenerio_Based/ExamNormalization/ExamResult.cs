namespace ExamNormalization
{
    public class ExamResult
    {
        public string StudentName { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }

        public ExamResult(string name, int score)
        {
            StudentName = name;
            Score = score;
            Rank = 0;
        }
    }
}