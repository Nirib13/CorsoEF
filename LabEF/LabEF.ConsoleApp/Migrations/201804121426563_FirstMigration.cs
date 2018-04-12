namespace LabEF.ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fatture",
                c => new
                    {
                        FatturaId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Num = c.String(),
                    })
                .PrimaryKey(t => t.FatturaId);
            
            CreateTable(
                "dbo.VociFatture",
                c => new
                    {
                        VoceFatturaID = c.Int(nullable: false, identity: true),
                        Qta = c.Int(nullable: false),
                        Descrizione = c.String(),
                        Imponibile = c.Double(nullable: false),
                        Fattura_FatturaId = c.Int(),
                    })
                .PrimaryKey(t => t.VoceFatturaID)
                .ForeignKey("dbo.Fatture", t => t.Fattura_FatturaId)
                .Index(t => t.Fattura_FatturaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VociFatture", "Fattura_FatturaId", "dbo.Fatture");
            DropIndex("dbo.VociFatture", new[] { "Fattura_FatturaId" });
            DropTable("dbo.VociFatture");
            DropTable("dbo.Fatture");
        }
    }
}
