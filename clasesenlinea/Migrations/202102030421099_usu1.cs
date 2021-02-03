namespace clasesenlinea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usu1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "apellidoP", c => c.String());
            AddColumn("dbo.Usuarios", "apellidoM", c => c.String());
            AddColumn("dbo.Usuarios", "email", c => c.String());
            AddColumn("dbo.Usuarios", "FechaCreacion", c => c.DateTime(nullable: false));
            DropColumn("dbo.Usuarios", "apellido");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "apellido", c => c.String());
            DropColumn("dbo.Usuarios", "FechaCreacion");
            DropColumn("dbo.Usuarios", "email");
            DropColumn("dbo.Usuarios", "apellidoM");
            DropColumn("dbo.Usuarios", "apellidoP");
        }
    }
}
