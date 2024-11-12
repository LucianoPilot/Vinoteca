using Vinoteca.Data.Entities;

namespace Vinoteca.Data.Interfaces
{
    public interface ICataRepository
    {
        void AddCata(Cata cata);
        List<Cata> GetAllCatas();
    }
}
