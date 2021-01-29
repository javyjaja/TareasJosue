namespace clasesenlinea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uno : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
