using Microsoft.EntityFrameworkCore;

namespace CDNsolutionWebAPI.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}
