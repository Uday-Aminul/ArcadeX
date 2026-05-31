using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Data;
using ArcadeX.Api.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Repositories.SQLUser
{
    public class UserRepository : IUserRepository
    {
        private readonly ArcadeXAuthDbContext _dbContext;
        public UserRepository(ArcadeXAuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> CreateUserAsync(User User)
        {
            await _dbContext.Users.AddAsync(User);
            await _dbContext.SaveChangesAsync();
            return User;
        }

        public async Task<List<User>?> DeleteUserByIdAsync(string id)
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

        public async Task<User?> GetUserByIdAsync(string id)
        {
            var userDomain = await _dbContext.Users.FirstOrDefaultAsync(g => g.Id == id);
            if (userDomain is null)
            {
                return null;
            }
            return userDomain;
        }

        public async Task<User?> UpdateUserByIdAsync(string id, User user)
        {
            var userDomain = _dbContext.Users.FirstOrDefault(g => g.Id == id);
            if (userDomain is null)
            {
                return null;
            }
            userDomain.UserName = user.UserName;
            userDomain.Email = user.Email;
            userDomain.PasswordHash = user.PasswordHash;
            userDomain.WalletBalance = user.WalletBalance;
            userDomain.DateOfBirth = user.DateOfBirth;

            await _dbContext.SaveChangesAsync();
            return userDomain;
        }
    }
}