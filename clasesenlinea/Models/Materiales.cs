using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clasesenlinea.Models
{
    public class Materiales
    {
       [Key]
        public int materialId { get; set; }
        public int parcial { get; set; }
        public string descripcion { get; set; }
        public string url { get; set; }
        public bool activo { get; set; }
    }
}