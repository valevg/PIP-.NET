namespace PROGINETPRIL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public User? User { get; set; }
    }
}
