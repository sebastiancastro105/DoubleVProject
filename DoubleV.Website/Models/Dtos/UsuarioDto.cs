using System;

namespace DoubleV.Website.Models.Dtos
{
    public class UsuarioDto
    {
        public int Identificador { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
