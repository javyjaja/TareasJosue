using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clasesenlinea.Models
{
    public class imagen
    {

        [Key]
        public int imagenId { get; set; }
        public int usuarioId { get; set; }
        public string TareaId { get; set; }
        public string password { get; set; }
        public string apellido { get; set; }
    }
}