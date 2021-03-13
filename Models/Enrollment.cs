namespace ContosoUniversity.Models
{//tinfo200:[2021-03-12-kfrey02-dykstra2]added enrollment class underneath the Contoso university
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}