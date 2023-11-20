namespace ControleVeiculo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        COD = c.Int(nullable: false, identity: true),
                        MODELO = c.String(),
                        MARCA = c.String(),
                        ANO = c.Int(nullable: false),
                        PRECO = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.COD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculoes");
        }
    }
}
