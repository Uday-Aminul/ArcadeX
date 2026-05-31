using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Data
{
    public class ArcadeXAuthDbContext : IdentityDbContext<User>
    {
        public ArcadeXAuthDbContext(DbContextOptions<ArcadeXAuthDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "3a4c51c5-9f18-4c2f-9024-7cce011b2e15";
            var writerRoleId = "d6b4a1cb-2f93-4d2e-bec8-94cd3d46f6c8";
            var roles = new List<IdentityRole>()
            {
                new IdentityRole(){
                    Id=readerRoleId,
                    Name="Reader",
                    ConcurrencyStamp=readerRoleId,
                    NormalizedName="Reader".ToUpper()
                },
                new IdentityRole(){
                    Id=writerRoleId,
                    Name="Writer",
                    ConcurrencyStamp=writerRoleId,
                    NormalizedName="Writer".ToUpper()
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            // Seed Users
            var users = new List<User>
            {
                new User
                {
                    Id = "1",
                    UserName = "john_doe",
                    Email = "john@example.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword1",  // dummy hash
                    WalletBalance = 150.00m,
                    AccountCreatedAt = new DateTime(2024, 11, 1),
                    DateOfBirth = new DateTime(1995, 5, 15)
                },
                new User
                {
                    Id = "2",
                    UserName = "jane_smith",
                    Email = "jane@example.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword2",
                    WalletBalance = 75.50m,
                    AccountCreatedAt = new DateTime(2024, 10, 15),
                    DateOfBirth = new DateTime(1998, 8, 22)
                },
                new User
                {
                    Id = "3",
                    UserName = "admin_user",
                    Email = "admin@arcadex.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword3",
                    WalletBalance = 1000.00m,
                    AccountCreatedAt = new DateTime(2024, 9, 1),
                    DateOfBirth = new DateTime(1985, 3, 10)
                },
                new User
                {
                    Id = "4",
                    UserName = "game_dev",
                    Email = "dev@arcadex.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword4",
                    WalletBalance = 500.00m,
                    AccountCreatedAt = new DateTime(2024, 11, 10),
                    DateOfBirth = new DateTime(1990, 12, 1)
                },
                new User
                {
                    Id = "5",
                    UserName = "inactive_user",
                    Email = "inactive@example.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword5",
                    WalletBalance = 0.00m,
                    AccountCreatedAt = new DateTime(2024, 8, 1),
                    DateOfBirth = new DateTime(2000, 1, 1)
                }
            };
            builder.Entity<User>().HasData(users);
        }

    }
}