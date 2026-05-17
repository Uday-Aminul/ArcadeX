using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;

namespace ArcadeX.Api.Repositories.SQLReview
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetAllReviewsAsync();
        Task<Review?> GetReviewByIdAsync(int id);
        Task<Review> CreateReviewAsync(Review Review);
        Task<Review?> UpdateReviewByIdAsync(int id, Review Review);
        Task<List<Review>?> DeleteReviewByIdAsync(int id);
    }
}