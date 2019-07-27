namespace AllExpirience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Helps",
                c => new
                    {
                        HelpId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Message = c.String(nullable: false, maxLength: 255),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HelpId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Helps", "CountryId", "dbo.Countries");
            DropIndex("dbo.Helps", new[] { "CountryId" });
            DropTable("dbo.Helps");
            DropTable("dbo.Countries");
        }
    }
}
