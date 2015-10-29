namespace Abonnement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonnements",
                c => new
                    {
                        KundeId = c.Int(nullable: false, identity: true),
                        År = c.Int(nullable: false),
                        Måned = c.Int(nullable: false),
                        Betalt = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KundeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abonnements");
        }
    }
}
