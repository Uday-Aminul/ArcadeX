using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcadeX.Api.Models.DTOs.Auth
{
    public class RegisterRequestDto
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string>? Roles { get; set; }
    }
}