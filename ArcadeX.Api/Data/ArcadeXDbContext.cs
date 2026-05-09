using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Data
{
    public class ArcadeXDbContext : DbContext
    {
        public ArcadeXDbContext(DbContextOptions<ArcadeXDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Users
            var Users = new List<User>
            {
                new User { Id = 1, Username = "john_doe", Email = "john@example.com", PasswordHash = "password123", Role = "Customer", WalletBalance = 150.00m, CreatedAt = new DateTime(2024, 11, 1), LastLoginAt = new DateTime(2024, 12, 1), IsActive = true },
                new User { Id = 2, Username = "jane_smith", Email = "jane@example.com", PasswordHash = "password123", Role = "Customer", WalletBalance = 75.50m, CreatedAt = new DateTime(2024, 10, 15), LastLoginAt = new DateTime(2024, 11, 30), IsActive = true },
                new User { Id = 3, Username = "admin_user", Email = "admin@arcadex.com", PasswordHash = "admin123", Role = "Admin", WalletBalance = 1000.00m, CreatedAt = new DateTime(2024, 9, 1), LastLoginAt = new DateTime(2024, 12, 2), IsActive = true },
                new User { Id = 4, Username = "game_dev", Email = "dev@arcadex.com", PasswordHash = "dev123", Role = "Developer", WalletBalance = 500.00m, CreatedAt = new DateTime(2024, 11, 10), LastLoginAt = new DateTime(2024, 11, 28), IsActive = true },
                new User { Id = 5, Username = "inactive_user", Email = "inactive@example.com", PasswordHash = "password123", Role = "Customer", WalletBalance = 0.00m, CreatedAt = new DateTime(2024, 8, 1), LastLoginAt = new DateTime(2024, 10, 1), IsActive = false }
            };
            modelBuilder.Entity<User>().HasData(Users);

            // Seed Games
            var Games = new List<Game>
            {
                new Game { Id = 1, Title = "Cyberpunk 2077", Description = "Open-world action RPG set in a dystopian future", Price = 59.99m, Category = "RPG", CoverImageUrl = "/images/games/cyberpunk.jpg", DownloadCount = 12500, DeveloperId = 4 },
                new Game { Id = 2, Title = "The Witcher 3", Description = "Epic fantasy RPG with rich storytelling", Price = 39.99m, Category = "RPG", CoverImageUrl = "/images/games/witcher3.jpg", DownloadCount = 25000, DeveloperId = 4 },
                new Game { Id = 3, Title = "Call of Duty: Warzone", Description = "Free-to-play battle royale shooter", Price = 0.00m, Category = "Action", CoverImageUrl = "/images/games/cod.jpg", DownloadCount = 50000, DeveloperId = null },
                new Game { Id = 4, Title = "Minecraft", Description = "Build and explore infinite worlds", Price = 29.99m, Category = "Sandbox", CoverImageUrl = "/images/games/minecraft.jpg", DownloadCount = 100000, DeveloperId = null },
                new Game { Id = 5, Title = "Among Us", Description = "Multiplayer party game of teamwork and betrayal", Price = 4.99m, Category = "Party", CoverImageUrl = "/images/games/amongus.jpg", DownloadCount = 75000, DeveloperId = null }
            };
            modelBuilder.Entity<Game>().HasData(Games);

            // Seed Reviews
            var Reviews = new List<Review>
            {
                new Review { Id = 1, Rating = 5, Comment = "Amazing game! Best RPG I've played in years.", CreatedAt = new DateTime(2024, 11, 20), UserId = 1, GameId = 1 },
                new Review { Id = 2, Rating = 4, Comment = "Great graphics but a bit buggy sometimes.", CreatedAt = new DateTime(2024, 11, 25), UserId = 2, GameId = 1 },
                new Review { Id = 3, Rating = 5, Comment = "Masterpiece! The story and gameplay are perfect.", CreatedAt = new DateTime(2024, 11, 15), UserId = 1, GameId = 2 },
                new Review { Id = 4, Rating = 5, Comment = "My childhood game. Still playing in 2024!", CreatedAt = new DateTime(2024, 11, 10), UserId = 3, GameId = 4 },
                new Review { Id = 5, Rating = 3, Comment = "Fun with friends but gets repetitive quickly.", CreatedAt = new DateTime(2024, 11, 28), UserId = 2, GameId = 5 }
            };
            modelBuilder.Entity<Review>().HasData(Reviews);
        }
    }
}