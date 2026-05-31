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
                    Category = new List<Category>{Category.RPG},  // Changed from string to enum
                    CoverImageUrl = "/images/games/cyberpunk.jpg",
                    DownloadCount = 12500,
                    DeveloperId = "4"  // Changed to string (User Id is string from IdentityUser)
                },
                new Game
                {
                    Id = 2,
                    Title = "The Witcher 3",
                    Description = "Epic fantasy RPG with rich storytelling",
                    Price = 39.99m,
                    Category = new List<Category>{Category.RPG},
                    CoverImageUrl = "/images/games/witcher3.jpg",
                    DownloadCount = 25000,
                    DeveloperId = "4"
                },
                new Game
                {
                    Id = 3,
                    Title = "Call of Duty: Warzone",
                    Description = "Free-to-play battle royale shooter",
                    Price = 0.00m,
                    Category = new List<Category>{Category.Action},
                    CoverImageUrl = "/images/games/cod.jpg",
                    DownloadCount = 50000,
                    DeveloperId = null
                },
                new Game
                {
                    Id = 4,
                    Title = "Minecraft",
                    Description = "Build and explore infinite worlds",
                    Price = 29.99m,
                    Category = new List<Category>{Category.Adventure},
                    CoverImageUrl = "/images/games/minecraft.jpg",
                    DownloadCount = 100000,
                    DeveloperId = null
                },
                new Game
                {
                    Id = 5,
                    Title = "Among Us",
                    Description = "Multiplayer party game of teamwork and betrayal",
                    Price = 4.99m,
                    Category = new List<Category>{Category.Arcade},
                    CoverImageUrl = "/images/games/amongus.jpg",
                    DownloadCount = 75000,
                    DeveloperId = null
                }
            };
            modelBuilder.Entity<Game>().HasData(Games);

            // Seed Reviews
            var Reviews = new List<Review>
            {
                new Review { Id = 1, Rating = 5, Messege = "Amazing game! Best RPG I've played in years.", CreatedAt = new DateTime(2024, 11, 20), UserId = "1", GameId = 1 },
                new Review { Id = 2, Rating = 4, Messege = "Great graphics but a bit buggy sometimes.", CreatedAt = new DateTime(2024, 11, 25), UserId = "2", GameId = 1 },
                new Review { Id = 3, Rating = 5, Messege = "Masterpiece! The story and gameplay are perfect.", CreatedAt = new DateTime(2024, 11, 15), UserId = "1", GameId = 2 },
                new Review { Id = 4, Rating = 5, Messege = "My childhood game. Still playing in 2024!", CreatedAt = new DateTime(2024, 11, 10), UserId = "3", GameId = 4 },
                new Review { Id = 5, Rating = 3, Messege = "Fun with friends but gets repetitive quickly.", CreatedAt = new DateTime(2024, 11, 28), UserId = "2", GameId = 5 }
            };
            modelBuilder.Entity<Review>().HasData(Reviews);
        }
    }
}