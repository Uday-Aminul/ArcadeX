using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;

namespace ArcadeX.Api.Repositories.SQLGame
{
    public interface IGameRepository
    {
        Task<List<Game>> GetAllGamesAsync();
        Task<Game?> GetGameByIdAsync(int id);
        Task<Game> CreateGameAsync(Game Game);
        Task<Game?> UpdateGameByIdAsync(int id, Game Game);
        Task<List<Game>?> DeleteGameByIdAsync(int id);
    }
}