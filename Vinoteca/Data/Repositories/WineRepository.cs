using Vinoteca.Data.Entities;
using Vinoteca.Data.Interfaces;

namespace Vinoteca.Data.Repositories
{
    public class WineRepository : IWineRepository
    {
        private readonly VinotecaContext _context;
        public WineRepository(VinotecaContext context)
        {
            _context = context;
        }
        public void AddWine(Wine wine)
        {
            _context.Wines.Add(wine);
            _context.SaveChangesAsync();
        }

        public List<Wine> GetAllWines()
        {
            return _context.Wines.ToList();
        }

        public List<Wine> GetStockByVariety(string variety)
        {
            return _context.Wines
                .Where(w => w.Variety.ToLower() == variety.ToLower() && w.Stock > 0)
                .ToList();
        }
        public void UpdateWineStock(int wineId, int stock)
        {
            var wineToUpdate = _context.Wines.FirstOrDefault(w => w.Id == wineId);

            if (wineToUpdate == null)
                throw new Exception("Vino no encontrado");

            wineToUpdate.Stock = stock;
            _context.SaveChanges();
        }

    }
}
