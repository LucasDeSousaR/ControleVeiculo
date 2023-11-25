namespace ControleVeiculo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeDaMigracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculoes", "ImagemUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculoes", "ImagemUrl");
        }
    }
}
