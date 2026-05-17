using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Data;
using ArcadeX.Api.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace ArcadeX.Api.Repositories.SQLGame
{
    public class GameRepository : IGameRepository
    {
        private readonly ArcadeXDbContext _dbContext;
        public GameRepository(ArcadeXDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Game> CreateGameAsync(Game Game)
        {
            await _dbContext.Games.AddAsync(Game);
            await _dbContext.SaveChangesAsync();
            return Game;
        }

        public async Task<List<Game>?> DeleteGameByIdAsync(int id)
        {
            var gameDomain = await _dbContext.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (gameDomain is null)
            {
                return null;
            }
            _dbContext.Games.Remove(gameDomain);
            await _dbContext.SaveChangesAsync();
            var gameDomains = await _dbContext.Games.ToListAsync();
            return gameDomains;
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            var gameDomains = await _dbContext.Games.ToListAsync();
            return gameDomains;
        }

        public async Task<Game?> GetGameByIdAsync(int id)
        {
            var gameDomain = await _dbContext.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (gameDomain is null)
            {
                return null;
            }
            return gameDomain;
        }

        public async Task<Game?> UpdateGameByIdAsync(int id, Game Game)
        {
            var gameDomain = _dbContext.Games.FirstOrDefault(g => g.Id == id);
            if (gameDomain is null)
            {
                return null;
            }
            gameDomain.Title = Game.Title;
            gameDomain.Description = Game.Description;
            gameDomain.Price = Game.Price;
            gameDomain.Category = Game.Category;
            gameDomain.CoverImageUrl = Game.CoverImageUrl;
            gameDomain.Reviews = Game.Reviews;
            await _dbContext.SaveChangesAsync();
            return gameDomain;
        }
    }
}