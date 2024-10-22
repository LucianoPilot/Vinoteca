using Vinoteca.Data.Entities;

namespace Vinoteca.Repositories
{
    public class WineRepository
    {
        private List<Wine> wines;
        private List<User> users;

        public WineRepository()
        {
            wines = new List<Wine>();
            users = new List<User>();
        }
        public async Task AddWine(Wine wine)
        {
            _context.Wines.Add(wine);
            await _context.SaveChangesAsync();
        }


        public List<Wine> GetAllWines()
        {
            return wines;
        }

        public Wine GetWineByName(string name)
        {
            return wines.FirstOrDefault(w => w.Name.ToLower() == name.ToLower());
        }

        public void UpdateStock(int wineId, int newStock)
        {
            var wine = wines.FirstOrDefault(w => w.Id == wineId);
            if (wine != null)
            {
                wine.Stock = newStock;
            }
        }
        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }


        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        private readonly WineDbContext _context;

            public WineRepository(WineDbContext context)
            {
                _context = context;
            }

        public async Task<Wine> GetWineByIdAsync(int id)
        {
            return await _context.Wines.FindAsync(id);
        }


    }

}
