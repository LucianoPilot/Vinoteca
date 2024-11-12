using Vinoteca.Data.Entities;

namespace Vinoteca.Data.Interfaces
{
    public interface IWineRepository
    {
            
        void AddWine(Wine wine);
        List<Wine> GetAllWines();
        List<Wine> GetStockByVariety(string variety);
        void UpdateWineStock(int wineId, int stock);
    }
}
