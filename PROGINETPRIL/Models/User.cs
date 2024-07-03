using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROGINETPRIL.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Students? Students { get; set; }
        public Teachers? Teachers { get; set; }
        public Employee? Employee { get; set; }
    }
}