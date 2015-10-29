using System.Data.Entity.Migrations;

namespace KundeData.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kundes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ForNavn = c.String(),
                        EtterNavn = c.String(),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kundes");
        }
    }
}
