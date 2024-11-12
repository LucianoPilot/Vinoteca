using Vinoteca.Data.Entities;
using Vinoteca.Data.Interfaces;
using Vinoteca.Models;
using Vinoteca.Services.Interface;

namespace Vinoteca.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser(CreateUserDTO dto)
        {
            User newUser = new User()
            {
                UserName = dto.Username,
                Password = dto.Password,
                Rol = Data.Rol.User
            };
            _userRepository.AddUser(newUser);
        }

        public User? ValidateUser(AuthDTO authDTO)
        {
            return _userRepository.GetUserByUsernameAndPassword(authDTO.UserName, authDTO.Password);
        }
    }
}
