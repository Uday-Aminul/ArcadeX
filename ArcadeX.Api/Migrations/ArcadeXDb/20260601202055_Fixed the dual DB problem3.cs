using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcadeX.Api.Migrations.ArcadeXDb
{
    /// <inheritdoc />
    public partial class FixedthedualDBproblem3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WalletBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GamePlayUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadCount = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeRating = table.Column<int>(type: "int", nullable: false),
                    SystemRequirements = table.Column<int>(type: "int", nullable: false),
                    DeveloperId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_User_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    PeopleReviewed = table.Column<int>(type: "int", nullable: false),
                    Messege = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_Reviews_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRating", "Category", "CoverImageUrl", "Description", "DeveloperId", "DownloadCount", "DownloadUrl", "GameImageUrl", "GamePlayUrl", "Price", "ReleaseDate", "SystemRequirements", "Title" },
                values: new object[,]
                {
                    { 1, 4, "[8]", "/images/games/cyberpunk.jpg", "Open-world action RPG set in a dystopian future", null, 12500, "/downloads/cyberpunk", null, null, 59.99m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cyberpunk 2077" },
                    { 2, 4, "[8]", "/images/games/witcher3.jpg", "Epic fantasy RPG with rich storytelling", null, 25000, "/downloads/witcher3", null, null, 39.99m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "The Witcher 3" },
                    { 3, 3, "[0]", "/images/games/cod.jpg", "Free-to-play battle royale shooter", null, 50000, "/downloads/warzone", null, null, 0.00m, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Call of Duty: Warzone" },
                    { 4, 1, "[1]", "/images/games/minecraft.jpg", "Build and explore infinite worlds", null, 100000, "/downloads/minecraft", null, null, 29.99m, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Minecraft" },
                    { 5, 2, "[5]", "/images/games/amongus.jpg", "Multiplayer party game of teamwork and betrayal", null, 75000, "/downloads/amongus", null, null, 4.99m, new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Among Us" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "GameId", "Messege", "PeopleReviewed", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Amazing game! Best RPG I've played in years.", 0, 5.0, null },
                    { 2, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Great graphics but a bit buggy sometimes.", 0, 4.0, null },
                    { 3, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Masterpiece! The story and gameplay are perfect.", 0, 5.0, null },
                    { 4, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "My childhood game. Still playing in 2024!", 0, 5.0, null },
                    { 5, new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Fun with friends but gets repetitive quickly.", 0, 3.0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

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
                name: "User");
        }
    }
}
