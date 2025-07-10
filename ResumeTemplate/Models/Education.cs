namespace ResumeAPI.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }
        public int Year { get; set; }
        public int ResumeId { get; set; }
    }
}
