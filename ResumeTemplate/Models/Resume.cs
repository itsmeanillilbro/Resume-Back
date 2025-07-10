using ResumeAPI.Models;
using System.Collections.Generic;

namespace ResumeTemplate.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
