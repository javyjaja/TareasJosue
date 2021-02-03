using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clasesenlinea.Models
{
    public class Usuario
    {

        [Key]
        public int usuarioId { get; set; }
        [Display(Name = "Clave")]
        public string username { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string apellidoP { get; set; }

        [Display(Name = "Apellido Materno")]
        public string apellidoM { get; set; }

        [Display(Name = "e-mail")]
        public string email { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}