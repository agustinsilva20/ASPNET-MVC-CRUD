namespace SistemaWebVuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vuelo",
                c => new
                    {
                        VueloID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Destino = c.String(nullable: false, maxLength: 50, unicode: false),
                        Origen = c.String(nullable: false, maxLength: 50, unicode: false),
                        Matricula = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.VueloID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vuelo");
        }
    }
}
