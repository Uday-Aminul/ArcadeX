using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcadeX.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadCount = table.Column<int>(type: "int", nullable: false),
                    DeveloperId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WalletBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Category", "CoverImageUrl", "Description", "DeveloperId", "DownloadCount", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "RPG", "/images/games/cyberpunk.jpg", "Open-world action RPG set in a dystopian future", 4, 12500, 59.99m, "Cyberpunk 2077" },
                    { 2, "RPG", "/images/games/witcher3.jpg", "Epic fantasy RPG with rich storytelling", 4, 25000, 39.99m, "The Witcher 3" },
                    { 3, "Action", "/images/games/cod.jpg", "Free-to-play battle royale shooter", null, 50000, 0.00m, "Call of Duty: Warzone" },
                    { 4, "Sandbox", "/images/games/minecraft.jpg", "Build and explore infinite worlds", null, 100000, 29.99m, "Minecraft" },
                    { 5, "Party", "/images/games/amongus.jpg", "Multiplayer party game of teamwork and betrayal", null, 75000, 4.99m, "Among Us" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "LastLoginAt", "PasswordHash", "Role", "Username", "WalletBalance" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 9, 23, 10, 30, 167, DateTimeKind.Local).AddTicks(3417), "john@example.com", true, new DateTime(2026, 5, 8, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(4490), "password123", "Customer", "john_doe", 150.00m },
                    { 2, new DateTime(2026, 3, 25, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5046), "jane@example.com", true, new DateTime(2026, 5, 7, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5049), "password123", "Customer", "jane_smith", 75.50m },
                    { 3, new DateTime(2026, 3, 10, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5052), "admin@arcadex.com", true, new DateTime(2026, 5, 8, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5052), "admin123", "Admin", "admin_user", 1000.00m },
                    { 4, new DateTime(2026, 4, 19, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5074), "dev@arcadex.com", true, new DateTime(2026, 5, 6, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5075), "dev123", "Developer", "game_dev", 500.00m },
                    { 5, new DateTime(2026, 2, 8, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5077), "inactive@example.com", false, new DateTime(2026, 3, 10, 23, 10, 30, 168, DateTimeKind.Local).AddTicks(5078), "password123", "Customer", "inactive_user", 0.00m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Amazing game! Best RPG I've played in years.", new DateTime(2026, 4, 29, 23, 10, 30, 170, DateTimeKind.Local).AddTicks(2113), 1, 5, 1 },
                    { 2, "Great graphics but a bit buggy sometimes.", new DateTime(2026, 5, 4, 23, 10, 30, 170, DateTimeKind.Local).AddTicks(2547), 1, 4, 2 },
                    { 3, "Masterpiece! The story and gameplay are perfect.", new DateTime(2026, 4, 24, 23, 10, 30, 170, DateTimeKind.Local).AddTicks(2550), 2, 5, 1 },
                    { 4, "My childhood game. Still playing in 2024!", new DateTime(2026, 4, 19, 23, 10, 30, 170, DateTimeKind.Local).AddTicks(2552), 4, 5, 3 },
                    { 5, "Fun with friends but gets repetitive quickly.", new DateTime(2026, 5, 6, 23, 10, 30, 170, DateTimeKind.Local).AddTicks(2554), 5, 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
