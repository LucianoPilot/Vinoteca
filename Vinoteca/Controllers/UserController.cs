using Microsoft.AspNetCore.Mvc;
using Vinoteca.Entities;
using Vinoteca.Repositories;

namespace Vinoteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly WineRepository _repository;

        public UserController(WineRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            _repository.AddUser(user);
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _repository.GetAllUsers();
            return Ok(users);
        }
    }

}
