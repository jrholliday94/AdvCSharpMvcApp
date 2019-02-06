namespace MvcWk2App.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializingDatabaseWithGames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Guid(nullable: false),
                        GameName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
