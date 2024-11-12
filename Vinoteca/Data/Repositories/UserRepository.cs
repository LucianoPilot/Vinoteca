using Vinoteca.Data.Entities;
using Vinoteca.Data.Interfaces;

namespace Vinoteca.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly VinotecaContext _context;

        public UserRepository(VinotecaContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.AddAsync(user);
            _context.SaveChangesAsync();
        }

        public User? GetUserByUsernameAndPassword(string username, string password)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == username && p.Password == password);
        }

    }
}
