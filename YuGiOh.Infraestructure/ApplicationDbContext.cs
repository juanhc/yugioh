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
        public DbSet<CardImage> CardImages { get; set; }
        public DbSet<CardPrice> CardPrices { get; set; }
        public DbSet<CardSet> CardSets { get; set; }
    }
}
