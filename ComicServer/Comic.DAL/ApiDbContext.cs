using Microsoft.EntityFrameworkCore;
using Comic.DAL.Models;

namespace Comic.DAL
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        // Mapping Entities (Models)
        public DbSet<ComicModel> Comic { get; set; }
    }
}
