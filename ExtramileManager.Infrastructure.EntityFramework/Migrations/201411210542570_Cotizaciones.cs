namespace ExtramileManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cotizaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cotizaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Tipo = c.String(),
                        Carga = c.String(),
                        Contr_M3 = c.String(),
                        Servicio = c.String(),
                        Condicion_Flete = c.String(),
                        Q_Type = c.String(),
                        Agente = c.String(),
                        Shipper = c.String(),
                        Consignee = c.String(),
                        Incoterm = c.String(),
                        Aduana = c.String(),
                        Fc_Comercial = c.String(),
                        Monto_USD = c.Single(nullable: false),
                        Fecha_Carga = c.DateTime(nullable: false),
                        Origen = c.String(),
                        POL_AOL = c.String(),
                        POD_AOD = c.String(),
                        Destino = c.String(),
                        Armador = c.String(),
                        Vss_Vol = c.String(),
                        ETD = c.DateTime(nullable: false),
                        ETA = c.DateTime(nullable: false),
                        MBL_MAWB_MCRT = c.String(),
                        HBL_HAWB_HCRT = c.String(),
                        Bandera = c.String(),
                        CutOff_Doc = c.String(),
                        CutOff_Fisico = c.String(),
                        Terminal_Fiscal = c.String(),
                        Seguro = c.String(),
                        ATA = c.String(),
                        Doc_Issue = c.String(),
                        Observaciones = c.String(),
                        Booking = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cotizaciones", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Cotizaciones", new[] { "Customer_Id" });
            DropTable("dbo.Cotizaciones");
        }
    }
}
