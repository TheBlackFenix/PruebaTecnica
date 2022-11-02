using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    
    public class Persona
    {
        [Required(ErrorMessage = "Debes ingresar un Documento")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Documento solo admiten valores Alfa Numericos")]
        public string Documento { get; set; }
        [Required(ErrorMessage = "Debes ingresar un Nombre")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Nombre solo admite letras")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Debes ingresar un valor")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Apellido solo admite letras")]
        public string Apellidos { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Debe Ingresar Por lo menos un medio de Contacto")]
        public DatosContacto DatosContacto { get; set; }
    }
}
