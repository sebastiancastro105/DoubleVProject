using System.ComponentModel.DataAnnotations;

namespace DoubleV.Api.Models
{
    public class Usuario
    {   [Key]
        public int Identificador { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
