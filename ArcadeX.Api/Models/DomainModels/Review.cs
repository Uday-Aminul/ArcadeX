using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;

namespace ArcadeX.Api.Models.DomainModels
{
    public class Review
    {
        public int Id { get; set; }
        public double Rating { get; set; } // 1-10 stars
        public int PeopleReviewed { get; set; }
        public string Messege { get; set; }
        public DateTime CreatedAt { get; set; }

        // Foreign Keys
        public String UserId { get; set; }
        public int GameId { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Game Game { get; set; }
    }
}