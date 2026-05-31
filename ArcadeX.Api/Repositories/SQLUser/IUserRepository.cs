using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;

namespace ArcadeX.Api.Repositories.SQLUser
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(string id);
        Task<User> CreateUserAsync(User User);
        Task<User?> UpdateUserByIdAsync(string id, User User);
        Task<List<User>?> DeleteUserByIdAsync(string id);
    }
}