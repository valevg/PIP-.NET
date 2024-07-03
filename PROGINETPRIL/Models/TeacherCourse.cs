using PROGINETPRIL.Models;

namespace PROGINETPRIL.Models
{
    public class TeacherCourse
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public Teachers Teacher { get; set; }
        public Course Course { get; set; }
    }
}
