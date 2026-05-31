using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DomainModels;
using ArcadeX.Api.Repositories.SQLUser;
using Microsoft.AspNetCore.Mvc;

namespace ArcadeX.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> GetAll()
        {
            var userDomains = await _userRepository.GetAllUsersAsync();
            return Ok(userDomains);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var userDomain = await _userRepository.GetUserByIdAsync(id);
            if (userDomain is null)
            {
                return NotFound();
            }
            return Ok(userDomain);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var userDomains = await _userRepository.DeleteUserByIdAsync(id);
            if (userDomains is null)
            {
                return NotFound();
            }
            return Ok(userDomains);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] User updateduser)
        {
            var userDomain = await _userRepository.UpdateUserByIdAsync(id, updateduser);
            if (userDomain is null)
            {
                return NotFound();
            }
            return Ok(userDomain);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User newuser)
        {
            var userDomain = await _userRepository.CreateUserAsync(newuser);
            return CreatedAtAction(nameof(GetById), new { id = userDomain.Id }, userDomain);
        }
    }
}