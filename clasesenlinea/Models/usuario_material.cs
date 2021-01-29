using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clasesenlinea.Models
{
    public class usuario_material
    {
        [Key]
        public int usuario_materialId { get; set; }
        public int usuarioId { get; set; }
        public int materialId { get; set; }
        public DateTime fecha { get; set; }
        public int TareaId { get; set; }
        public HttpPostedFileBase ArchivoFisico { get; set; }


    }
}