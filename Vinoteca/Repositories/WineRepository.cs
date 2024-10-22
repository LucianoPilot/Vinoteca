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
        public void AddWine(Wine wine)
        {
            wine.Id = wines.Count + 1;
            wines.Add(wine);
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
        public void AddUser(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }

}
