using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Data;
using ArcadeX.Api.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Repositories.SQLReview
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ArcadeXDbContext _dbContext;
        public ReviewRepository(ArcadeXDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Review> CreateReviewAsync(Review Review)
        {
            await _dbContext.Reviews.AddAsync(Review);
            await _dbContext.SaveChangesAsync();
            return Review;
        }

        public async Task<List<Review>?> DeleteReviewByIdAsync(int id)
        {
            var reviewDomain = await _dbContext.Reviews.FirstOrDefaultAsync(g => g.Id == id);
            if (reviewDomain is null)
            {
                return null;
            }
            _dbContext.Reviews.Remove(reviewDomain);
            await _dbContext.SaveChangesAsync();
            var reviewDomains = await _dbContext.Reviews.ToListAsync();
            return reviewDomains;
        }

        public async Task<List<Review>> GetAllReviewsAsync()
        {
            var reviewDomains = await _dbContext.Reviews.ToListAsync();
            return reviewDomains;
        }

        public async Task<Review?> GetReviewByIdAsync(int id)
        {
            var reviewDomain = await _dbContext.Reviews.FirstOrDefaultAsync(g => g.Id == id);
            if (reviewDomain is null)
            {
                return null;
            }
            return reviewDomain;
        }

        public async Task<Review?> UpdateReviewByIdAsync(int id, Review Review)
        {
            var reviewDomain = _dbContext.Reviews.FirstOrDefault(g => g.Id == id);
            if (reviewDomain is null)
            {
                return null;
            }
            reviewDomain.Rating = Review.Rating;
            reviewDomain.Comment = Review.Comment;
            reviewDomain.GameId = Review.GameId;
            reviewDomain.UserId = Review.UserId;
            reviewDomain.CreatedAt = Review.CreatedAt;
            await _dbContext.SaveChangesAsync();
            return reviewDomain;
        }
    }
}