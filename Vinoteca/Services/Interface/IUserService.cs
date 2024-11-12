using Vinoteca.Data.Entities;
using Vinoteca.Models;

namespace Vinoteca.Services.Interface
{
    public interface IUserService
    {
        void CreateUser(CreateUserDTO dto);
        User? ValidateUser(AuthDTO authDto);
    }
}
