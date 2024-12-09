using Microsoft.EntityFrameworkCore;

namespace CIS236FinalProject.Models
{
    public class GameDBContext : DbContext
    {
        public GameDBContext(DbContextOptions<GameDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Move> Moves { get; set; } = null!;
        public DbSet<Division> Divisions { get; set; } = null!;
        public DbSet<Badge> Badges { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John" },
                new User { Id = 2, Name = "Adam" }
                );

            modelBuilder.Entity<Division>().HasData(
                new Division { Id = 1, Name = "Bronze" },
                new Division { Id = 2, Name = "Silver" },
                new Division { Id = 3, Name = "Gold" }
                );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Alpha Squad", UserId = 1, MaxCharacters = 4, DivisionId = 1 },
                new Team { Id = 2, Name = "Beta Team", UserId = 2, MaxCharacters = 4, DivisionId = 2 }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character { Id = 1, Name = "Warrior", Attack = 50, Defense = 40, Speed = 30, TeamId = 1},
                new Character { Id = 2, Name = "Knight", Attack = 60, Defense = 50, Speed = 40, TeamId = 2 }
                );

            modelBuilder.Entity<Move>().HasData(
                new Move { Id = 1, Name = "Slash", Power = 20, CharacterId = 1},
                new Move { Id = 2, Name = "DoubleSlash", Power = 40, CharacterId = 2}
                );

            modelBuilder.Entity<Badge>().HasData(
                new Badge { Id = 1, Name = "First Victory", Description = "Awarded for winning their first battle", UserId = 1}
                );
        }


    }
}
