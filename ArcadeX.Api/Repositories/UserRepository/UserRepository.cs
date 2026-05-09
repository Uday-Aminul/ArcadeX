using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Data;
using ArcadeX.Api.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ArcadeXDbContext _dbContext;
        public UserRepository(ArcadeXDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> CreateUserAsync(User User)
        {
            await _dbContext.Users.AddAsync(User);
            await _dbContext.SaveChangesAsync();
            return User;
        }

        public async Task<List<User>?> DeleteUserByIdAsync(int id)
        {
            var userDomain = await _dbContext.Users.FirstOrDefaultAsync(g => g.Id == id);
            if (userDomain is null)
            {
                return null;
            }
            _dbContext.Users.Remove(userDomain);
            await _dbContext.SaveChangesAsync();
            var userDomains = await _dbContext.Users.ToListAsync();
            return userDomains;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var userDomains = await _dbContext.Users.ToListAsync();
            return userDomains;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            var userDomain = await _dbContext.Users.FirstOrDefaultAsync(g => g.Id == id);
            if (userDomain is null)
            {
                return null;
            }
            return userDomain;
        }

        public async Task<User?> UpdateUserByIdAsync(int id, User User)
        {
            var userDomain = _dbContext.Users.FirstOrDefault(g => g.Id == id);
            if (userDomain is null)
            {
                return null;
            }
            userDomain.Username = User.Username;
            userDomain.Email = User.Email;
            userDomain.PasswordHash = User.PasswordHash;
            userDomain.Role = User.Role;
            userDomain.WalletBalance = User.WalletBalance;
            userDomain.CreatedAt = User.CreatedAt;
            userDomain.LastLoginAt = User.LastLoginAt;
            userDomain.IsActive = User.IsActive;

            await _dbContext.SaveChangesAsync();
            return userDomain;
        }
    }
}