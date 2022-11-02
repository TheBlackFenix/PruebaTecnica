using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class DatosContacto
    {
        [DataType(DataType.PhoneNumber,ErrorMessage ="Debes ingresar un numero Valido")]
        public string Telefono { get; set; } = string.Empty;
        [DataType(DataType.PhoneNumber, ErrorMessage = "Debes ingresar un numero Valido")]
        public string Telefono2 { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = null;
        public string CorreoElectronico2 { get; set; } = null;
        public string Direccion { get; set; } = string.Empty;
        public string Direccion2 { get; set; } = string.Empty;
    }
}
