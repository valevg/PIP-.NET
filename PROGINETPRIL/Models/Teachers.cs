namespace PROGINETPRIL.Models
{
    public class Teachers
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string LastName { get; set; }
        public string Post { get; set; }
        public User? User { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}