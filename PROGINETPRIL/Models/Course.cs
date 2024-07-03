namespace PROGINETPRIL.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Status { get; set; }
        public string Info { get; set; }
        public int Id_Speciality { get; set; }
        public Specialties Speciality { get; set; }

        public int Id_Teacher { get; set; }
        public Teachers Teacher { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}