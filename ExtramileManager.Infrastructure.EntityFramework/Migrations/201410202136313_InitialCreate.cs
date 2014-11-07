namespace ExtramileManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Byte(nullable: false),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        Provincia = c.String(),
                        Pais = c.String(),
                        Cuit = c.String(),
                        IBrutos = c.String(),
                        Estado = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
