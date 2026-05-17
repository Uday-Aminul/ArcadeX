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
        Task<User?> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(User User);
        Task<User?> UpdateUserByIdAsync(int id, User User);
        Task<List<User>?> DeleteUserByIdAsync(int id);
    }
}