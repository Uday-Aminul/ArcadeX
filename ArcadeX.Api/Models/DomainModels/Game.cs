using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcadeX.Api.Models.DomainModels
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string CoverImageUrl { get; set; }
        //public string DownloadUrl { get; set; }
        public int DownloadCount { get; set; } = 0;
        //public DateTime ReleaseDate { get; set; }
        //public bool IsPublished { get; set; }

        // Foreign Keys
        public int? DeveloperId { get; set; }

        // Navigation Properties
        //public User? Developer { get; set; }
        public List<Review> Reviews { get; set; }
        // public List<Purchase> Purchases { get; set; }
        // public List<WishlistItem> WishlistItems { get; set; }
    }
}