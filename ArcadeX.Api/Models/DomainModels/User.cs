using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ArcadeX.Api.Models.DomainModels
{
    public class User : IdentityUser
    {
        public decimal WalletBalance { get; set; }
        public DateTime AccountCreatedAt { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation Properties
        public List<Review> Reviews { get; set; }
        public List<Game> BoughtGames { get; set; }
    }
}