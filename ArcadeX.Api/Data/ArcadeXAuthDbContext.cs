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
        new IdentityRole()
        {
            Id = readerRoleId,
            Name = "Reader",
            ConcurrencyStamp = readerRoleId,         // ✅ already static
            NormalizedName = "READER"                // ✅ hardcode instead of .ToUpper()
        },
        new IdentityRole()
        {
            Id = writerRoleId,
            Name = "Writer",
            ConcurrencyStamp = writerRoleId,         // ✅ already static
            NormalizedName = "WRITER"                // ✅ hardcode instead of .ToUpper()
        }
    };
            builder.Entity<IdentityRole>().HasData(roles);

            var users = new List<User>
    {
        new User
        {
            Id = "1",
            UserName = "john_doe",
            NormalizedUserName = "JOHN_DOE",                          // ✅ add this
            Email = "john@example.com",
            NormalizedEmail = "JOHN@EXAMPLE.COM",                     // ✅ add this
            EmailConfirmed = true,                                    // ✅ add this
            PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword1",
            SecurityStamp = "STATIC-SECURITY-STAMP-1",               // ✅ critical fix
            ConcurrencyStamp = "a1b2c3d4-0001-0000-0000-000000000001", // ✅ add this
            WalletBalance = 150.00m,
            AccountCreatedAt = new DateTime(2024, 11, 1),
            DateOfBirth = new DateTime(1995, 5, 15)
        },
        new User
        {
            Id = "2",
            UserName = "jane_smith",
            NormalizedUserName = "JANE_SMITH",
            Email = "jane@example.com",
            NormalizedEmail = "JANE@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword2",
            SecurityStamp = "STATIC-SECURITY-STAMP-2",
            ConcurrencyStamp = "a1b2c3d4-0001-0000-0000-000000000002",
            WalletBalance = 75.50m,
            AccountCreatedAt = new DateTime(2024, 10, 15),
            DateOfBirth = new DateTime(1998, 8, 22)
        },
        new User
        {
            Id = "3",
            UserName = "admin_user",
            NormalizedUserName = "ADMIN_USER",
            Email = "admin@arcadex.com",
            NormalizedEmail = "ADMIN@ARCADEX.COM",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword3",
            SecurityStamp = "STATIC-SECURITY-STAMP-3",
            ConcurrencyStamp = "a1b2c3d4-0001-0000-0000-000000000003",
            WalletBalance = 1000.00m,
            AccountCreatedAt = new DateTime(2024, 9, 1),
            DateOfBirth = new DateTime(1985, 3, 10)
        },
        new User
        {
            Id = "4",
            UserName = "game_dev",
            NormalizedUserName = "GAME_DEV",
            Email = "dev@arcadex.com",
            NormalizedEmail = "DEV@ARCADEX.COM",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword4",
            SecurityStamp = "STATIC-SECURITY-STAMP-4",
            ConcurrencyStamp = "a1b2c3d4-0001-0000-0000-000000000004",
            WalletBalance = 500.00m,
            AccountCreatedAt = new DateTime(2024, 11, 10),
            DateOfBirth = new DateTime(1990, 12, 1)
        },
        new User
        {
            Id = "5",
            UserName = "inactive_user",
            NormalizedUserName = "INACTIVE_USER",
            Email = "inactive@example.com",
            NormalizedEmail = "INACTIVE@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAEAACcQAAAAEExampleHashedPassword5",
            SecurityStamp = "STATIC-SECURITY-STAMP-5",
            ConcurrencyStamp = "a1b2c3d4-0001-0000-0000-000000000005",
            WalletBalance = 0.00m,
            AccountCreatedAt = new DateTime(2024, 8, 1),
            DateOfBirth = new DateTime(2000, 1, 1)
        }
    };
            builder.Entity<User>().HasData(users);
        }

    }
}