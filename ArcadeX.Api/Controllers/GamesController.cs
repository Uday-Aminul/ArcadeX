using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;
using ArcadeX.Api.Repositories.GameRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArcadeX.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;
        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> GetAll()
        {
            var gameDomains = await _gameRepository.GetAllGamesAsync();
            return Ok(gameDomains);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var gameDomain = await _gameRepository.GetGameByIdAsync(id);
            if (gameDomain is null)
            {
                return NotFound();
            }
            return Ok(gameDomain);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var gameDomains = await _gameRepository.DeleteGameByIdAsync(id);
            if (gameDomains is null)
            {
                return NotFound();
            }
            return Ok(gameDomains);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Game updatedgame)
        {
            var gameDomain = await _gameRepository.UpdateGameByIdAsync(id, updatedgame);
            if (gameDomain is null)
            {
                return NotFound();
            }
            return Ok(gameDomain);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Game newgame)
        {
            var gameDomain = await _gameRepository.CreateGameAsync(newgame);
            return CreatedAtAction(nameof(GetById), new { id = gameDomain.Id }, gameDomain);
        }
    }
}