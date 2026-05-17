using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcadeX.Api.Models.DTOs.Auth;
using ArcadeX.Api.Repositories.Token;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArcadeX.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _tokenRepository;
        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            _userManager = userManager;
            _tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto newUser)
        {
            var identityUser = new IdentityUser()
            {
                UserName = newUser.Username,
                Email = newUser.Email,
            };
            var identityResult = await _userManager.CreateAsync(identityUser, newUser.Password);
            if (identityResult.Succeeded)
            {
                if (newUser.Roles?.Any() is true)
                {
                    var roles = new List<string> { "Reader", "Writer" };
                    foreach (var role in newUser.Roles)
                    {
                        if (roles.Contains(role) is false)
                        {
                            return Ok("User was registered but roles couldn't be added.");
                        }
                    }
                    identityResult = await _userManager.AddToRolesAsync(identityUser, newUser.Roles);
                    if (identityResult.Succeeded)
                    {
                        return Ok("User was registered with the given roles now you can login.");
                    }
                    else
                    {
                        return Ok("User was registered but roles couldn't be added now u can login.");
                    }
                }
            }
            return BadRequest("User couldn't be registered.");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginRequestDto loginRequest)
        {
            var user = await _userManager.FindByEmailAsync(loginRequest.Email);
            if (user is not null)
            {
                var passwordResult = await _userManager.CheckPasswordAsync(user, loginRequest.Password);
                if (passwordResult is true)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles?.Any() is true)
                    {
                        var jwtToken = _tokenRepository.CreateJwtToken(user, roles.ToList());
                        return Ok(new { JwtToken = jwtToken });
                    }
                }
            }
            return BadRequest("Email or Password is incorrect.");
        }
    }
}