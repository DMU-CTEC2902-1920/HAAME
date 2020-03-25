namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        GameTitle = c.String(),
                        Console = c.String(),
                        GameGenre = c.String(),
                        Developer = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ratings = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
