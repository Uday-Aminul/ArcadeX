using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcadeX.Api.Models.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // "Customer", "Admin", "Developer"
        public decimal WalletBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public bool IsActive { get; set; }

        // Navigation Properties
        //public List<Purchase> Purchases { get; set; }
        public List<Review> Reviews { get; set; }
        //public List<WishlistItem> WishlistItems { get; set; }
    }
}