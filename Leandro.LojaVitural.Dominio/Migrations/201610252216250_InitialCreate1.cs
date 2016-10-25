namespace Leandro.LojaVitural.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Categoria", c => c.Int(nullable: false));
        }
    }
}
