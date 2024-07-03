using System.ComponentModel.DataAnnotations.Schema;

namespace PROGINETPRIL.Models
{
    public class Groups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public int StartYear { get; set; }
        public ICollection<Students> Students { get; set; }
    }
}