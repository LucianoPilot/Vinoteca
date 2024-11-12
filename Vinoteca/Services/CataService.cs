using System;
using Vinoteca.Data;
using Vinoteca.Data.Entities;

namespace Vinoteca.Services
{
    public class CataService
    {
        private readonly VinotecaContext _context;

        public CataService(VinotecaContext context)
        {
            _context = context;
        }

        public async Task<Cata> CreateCataAsync(Cata cata)
        {
            _context.Catas.Add(cata);
            await _context.SaveChangesAsync();
            return cata;
        }
    }


}
