using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace clasesenlinea.Models
{
    public class context:DbContext
    {
        public context() : base("strConn") { }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<usuario_material> usuario_materiales { get; set; }
        public DbSet<Materiales> _materiales { get; set; }
        
    }
}