using System.ComponentModel.DataAnnotations;

namespace Comic.DAL.Models
{
    public class ComicModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public string? RealName { get; set; } = null;
        public string? Characteristic { get; set; } = null;
        public string? Description { get; set; } = null;
        public int DebutYear { get; set; }
        public int NumberIssues { get; set; }
        public string? ImageUrl { get; set; } = null;
    }
}
