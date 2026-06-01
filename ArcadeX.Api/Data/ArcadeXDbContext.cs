using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;
using ArcadeX.Api.Models.DomainModels.EnumTypes;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Data
{
    public class ArcadeXDbContext : DbContext
    {
        public ArcadeXDbContext(DbContextOptions<ArcadeXDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Games
            var Games = new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Title = "Cyberpunk 2077",
                    Description = "Open-world action RPG set in a dystopian future",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2020, 12, 10),
                    Category = new List<Category>{Category.RPG},
                    AgeRating = AgeRating.PEGI_18,
                    CoverImageUrl = "/images/games/cyberpunk.jpg",
                    DownloadUrl = "/downloads/cyberpunk",
                    DownloadCount = 12500,
                    DeveloperId = null,
                    SystemRequirements = new SystemRequirements()
                },
                new Game
                {
                    Id = 2,
                    Title = "The Witcher 3",
                    Description = "Epic fantasy RPG with rich storytelling",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2015, 5, 19),
                    Category = new List<Category>{Category.RPG},
                    AgeRating = AgeRating.PEGI_18,
                    CoverImageUrl = "/images/games/witcher3.jpg",
                    DownloadUrl = "/downloads/witcher3",
                    DownloadCount = 25000,
                    DeveloperId = null,
                    SystemRequirements = new SystemRequirements()
                },
                new Game
                {
                    Id = 3,
                    Title = "Call of Duty: Warzone",
                    Description = "Free-to-play battle royale shooter",
                    Price = 0.00m,
                    ReleaseDate = new DateTime(2020, 3, 10),
                    Category = new List<Category>{Category.Action},
                    AgeRating = AgeRating.PEGI_16,
                    CoverImageUrl = "/images/games/cod.jpg",
                    DownloadUrl = "/downloads/warzone",
                    DownloadCount = 50000,
                    DeveloperId = null,
                    SystemRequirements = new SystemRequirements()
                },
                new Game
                {
                    Id = 4,
                    Title = "Minecraft",
                    Description = "Build and explore infinite worlds",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2011, 11, 18),
                    Category = new List<Category>{Category.Adventure},
                    AgeRating = AgeRating.PEGI_7,
                    CoverImageUrl = "/images/games/minecraft.jpg",
                    DownloadUrl = "/downloads/minecraft",
                    DownloadCount = 100000,
                    DeveloperId = null,
                    SystemRequirements = new SystemRequirements()
                },
                new Game
                {
                    Id = 5,
                    Title = "Among Us",
                    Description = "Multiplayer party game of teamwork and betrayal",
                    Price = 4.99m,
                    ReleaseDate = new DateTime(2018, 6, 15),
                    Category = new List<Category>{Category.Arcade},
                    AgeRating = AgeRating.PEGI_12,
                    CoverImageUrl = "/images/games/amongus.jpg",
                    DownloadUrl = "/downloads/amongus",
                    DownloadCount = 75000,
                    DeveloperId = null,
                    SystemRequirements = new SystemRequirements()
                }
            };
            modelBuilder.Entity<Game>().HasData(Games);

            // Seed Reviews
            var Reviews = new List<Review>
            {
                new Review { Id = 1, Rating = 5, Messege = "Amazing game! Best RPG I've played in years.", CreatedAt = new DateTime(2024, 11, 20), UserId = null, GameId = 1 },
                new Review { Id = 2, Rating = 4, Messege = "Great graphics but a bit buggy sometimes.", CreatedAt = new DateTime(2024, 11, 25), UserId = null, GameId = 1 },
                new Review { Id = 3, Rating = 5, Messege = "Masterpiece! The story and gameplay are perfect.", CreatedAt = new DateTime(2024, 11, 15), UserId = null, GameId = 2 },
                new Review { Id = 4, Rating = 5, Messege = "My childhood game. Still playing in 2024!", CreatedAt = new DateTime(2024, 11, 10), UserId = null, GameId = 4 },
                new Review { Id = 5, Rating = 3, Messege = "Fun with friends but gets repetitive quickly.", CreatedAt = new DateTime(2024, 11, 28), UserId = null, GameId = 5 }
            };
            modelBuilder.Entity<Review>().HasData(Reviews);
        }
    }
}