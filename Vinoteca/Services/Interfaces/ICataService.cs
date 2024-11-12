using Models.DTOs;
using Vinoteca.Models;

namespace Vinoteca.Services.Interfaces
{
    public interface ICataService
    {
        public interface IWineService
        {
            void CreateWine(CreateWineDTO dto);
            List<GetWineDTO> GetAllWine();
            List<GetStockDTO> GetStockByVariety(string variety);
            void UpdateWineStock(int wineId, UpdateWineStockDTO dto);
        }
    }
}
