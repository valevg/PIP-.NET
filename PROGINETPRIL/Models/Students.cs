using System.ComponentModel.DataAnnotations.Schema;

namespace PROGINETPRIL.Models
{
    public class Students
    {
        public int UserId { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        [ForeignKey("Groups")]
        public int GroupId { get; set; }
        public string Form { get; set; }
        public int Status { get; set; }
        public User? User { get; set; }
        public Groups? Groups { get; set; }
        public Specialties? Specialties { get; set; }
        
    }
}