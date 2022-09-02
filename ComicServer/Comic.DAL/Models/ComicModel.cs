using System.ComponentModel.DataAnnotations;

namespace Comic.DAL.Models
{
    public class ComicModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string RealName { get; set; }
        [Required]
        public string Characteristic { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int DebutYear { get; set; }
        [Required]
        public int NumberIssues { get; set; }
    }
}
