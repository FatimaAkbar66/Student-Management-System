namespace Student_Management_System.Models
{
    public class Marks
    {
        public int MarkID { get; set; }
        public int StudentID { get; set; }
        public string Subject { get; set; }
        public float Score { get; set; }
        public string ExamType { get; set; }
    }
}
