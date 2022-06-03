using System.ComponentModel.DataAnnotations;

namespace DoubleV.Api.Models
{
    public class Persona
    {   [Key]
        public int Identificador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        /*public string NumeroTipoIdentificacion { get; set; }
        public string NombresApellidosIDentificacion { get; set; }*/
    }
}
