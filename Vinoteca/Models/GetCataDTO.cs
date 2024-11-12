using Vinoteca.Data.Entities;

namespace Vinoteca.Models
{
    public class GetCataDTO
    {
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public List<Wine> Wines { get; set; }
        public List<string> Invitados { get; set; }
    }
}
