using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels.EnumTypes;

namespace ArcadeX.Api.Models.DomainModels
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImageUrl { get; set; }
        public string? GamePlayUrl { get; set; }
        public List<string>? GameImageUrl { get; set; }
        public string DownloadUrl { get; set; }
        public int DownloadCount { get; set; } = 0;
        public List<Category> Category { get; set; }
        public AgeRating AgeRating { get; set; }
        public SystemRequirements SystemRequirements { get; set; }

        // Foreign Keys
        public string? DeveloperId { get; set; }

        // Navigation Properties
        public User? Developer { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}