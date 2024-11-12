using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vinoteca.Data.Entities;
using Vinoteca.Data.Repositories;
using Vinoteca.Models;
using Vinoteca.Services.Interface;

namespace Vinoteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserDTO dto)
        {
            _userService.CreateUser(dto);
            return Ok(dto);

        }
    }

}
