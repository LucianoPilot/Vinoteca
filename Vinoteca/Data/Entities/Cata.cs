﻿namespace Vinoteca.Data.Entities
{
    public class Cata
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public List<string> Invitados { get; set; }
        public List<Wine> Vinos { get; set; }
    }

}
