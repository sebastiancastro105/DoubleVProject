using System;
using System.ComponentModel.DataAnnotations;

namespace DoubleV.Website.Models.Dtos
{
    public class PersonaUsuarioDto
    {
        public int Identificador { get; set; }
      
        public string Nombres { get; set; } 

        
        public string Apellidos { get; set; }
         [Required]
        public string NumeroIdentificacion { get; set; }

       
        public string Email { get; set; }

         [Required]
        public string TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
         [Required]
        public string User { get; set; }
        [Required]
        public string Pass { get; set; }
    }
}
