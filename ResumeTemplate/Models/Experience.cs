namespace ResumeAPI.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public int ResumeId { get; set; }
    }
}
