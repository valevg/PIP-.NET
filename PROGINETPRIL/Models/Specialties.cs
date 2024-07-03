namespace PROGINETPRIL.Models
{
    public class Specialties
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyName { get; set; }
        public ICollection<Students> Students { get; set; }
    }
}