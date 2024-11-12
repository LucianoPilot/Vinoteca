using Models.DTOs;
using Vinoteca.Models;

namespace Vinoteca.Services.Interface
{
    public interface ICataService
    {
        void CreateCata(CataCreateDto dto);
        List<GetCataDTO> GetAllCata();
    }
}
