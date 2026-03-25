using System;

namespace Student_Management_System.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int StudentID { get; set; }
        public DateTime AttDate { get; set; }
        public string Status { get; set; }
    }
}