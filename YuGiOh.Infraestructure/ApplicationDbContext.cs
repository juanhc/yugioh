using Microsoft.EntityFrameworkCore;
using YuGiOh.Domain;

namespace YuGiOh.Infraestructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) 
        { }

        public DbSet<Card> Cards { get; set; }
    }
}
