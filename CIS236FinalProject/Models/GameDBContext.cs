using Microsoft.EntityFrameworkCore;

namespace CIS236FinalProject.Models
{
    public class GameDBContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Team> Teams { get; set; }

        public GameDBContext(DbContextOptions<GameDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
