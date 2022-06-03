using System;
using System.ComponentModel.DataAnnotations;

namespace DoubleV.Website.Models.Dtos
{
    public class PersonaUsuarioDto
    {
        public int Identificador { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerdio")]
        public string Nombres { get; set; } 

        [Required(ErrorMessage = "El campo {0} es requerdio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerdio")]
        public string NumeroIdentificacion { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerdio")]
        public string TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerdio")]
        public string User { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerdio")]
        public string Pass { get; set; }
    }
}
