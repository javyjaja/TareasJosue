namespace clasesenlinea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materiales",
                c => new
                    {
                        materialId = c.Int(nullable: false, identity: true),
                        parcial = c.Int(nullable: false),
                        descripcion = c.String(),
                        url = c.String(),
                        activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.materialId);
            
            CreateTable(
                "dbo.usuario_material",
                c => new
                    {
                        usuario_materialId = c.Int(nullable: false, identity: true),
                        usuarioId = c.Int(nullable: false),
                        materialId = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                        TareaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.usuario_materialId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        usuarioId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        nombre = c.String(),
                        password = c.String(),
                        apellido = c.String(),
                    })
                .PrimaryKey(t => t.usuarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.usuario_material");
            DropTable("dbo.Materiales");
        }
    }
}
