using Vinoteca.Data.Entities;

namespace Vinoteca.Data.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User? GetUserByUsernameAndPassword(string UserName, string Password);
    }
}
