using Vinoteca.Data.Entities;
using Vinoteca.Data.Interfaces;

namespace Vinoteca.Data.Repositories
{
    public class CataRepository : ICataRepository
    {
        private readonly VinotecaContext _context;
        public CataRepository(VinotecaContext context)
        {
            _context = context;
        }
        public void AddCata(Cata cata)
        {
            _context.Catas.Add(cata);
            _context.SaveChangesAsync();
        }

        public List<Cata> GetAllCatas()
        {
            return _context.Catas.ToList();
        }
    }
}
