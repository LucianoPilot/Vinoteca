using Vinoteca.Data.Entities;

namespace Vinoteca.Repositories
{
    public interface IWineRepository
    {
        Task<IEnumerable<Wine>> GetAllWinesAsync();
        Task<Wine> GetWineByIdAsync(int id);
        Task AddWineAsync(Wine wine);
        Task UpdateWineAsync(Wine wine);
        Task DeleteWineAsync(int id);
    }

}
